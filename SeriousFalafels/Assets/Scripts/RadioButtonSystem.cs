using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class RadioButtonSystem : MonoBehaviour
{
    ToggleGroup toggleGroup;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        Debug.Log(toggle.name + " _ " + toggle.GetComponentInChildren<Text>().text);
        transform.parent.gameObject.transform.parent.gameObject.SetActive(false); // get canva parent
        SpriteRenderer targetSpriteRend = target.GetComponent<SpriteRenderer>();
        Sprite targetCurrentSprite = targetSpriteRend.sprite;
    }

    public void SetTarget(GameObject obj) {
        target = obj;
    }
}
