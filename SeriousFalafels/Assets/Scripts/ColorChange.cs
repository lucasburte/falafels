using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    private int currentMode;
    private PlayerTurnController controller;
    [SerializeField]
    private GameObject canva;
    private RadioButtonSystem radioButton;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindWithTag("GameController").GetComponent<PlayerTurnController>();
        radioButton = canva.transform.Find("Panel").gameObject.transform.Find("OptionsButtons").GetComponent<RadioButtonSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        currentMode = controller.GetMode();
    }

    private void OnMouseDown() {
        if (currentMode == 1 && !canva.activeSelf) {
            canva.SetActive(true);
            radioButton.SetTarget(gameObject);
        }
    }
}
