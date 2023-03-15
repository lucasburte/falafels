using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeButtonController : MonoBehaviour
{
    public GameObject tableau;
    private List<DragNDrop> dragObjects;
    private int currentM;
    private PlayerTurnController controller;
    // Start is called before the first frame update
    void Start()
    {
        dragObjects = GameObject.FindWithTag("GameController").GetComponent<SnapController>().draggableObjects;
        controller = GameObject.FindWithTag("GameController").GetComponent<PlayerTurnController>();
        currentM = controller.GetMode();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentM == 1)
        {
            tableau.SetActive(false);
            foreach (DragNDrop draggable in dragObjects)
            {
                if (!draggable.IsSnapped())
                {
                    draggable.gameObject.SetActive(false);
                }
            }
        }

        if (currentM == 0)
        {
            tableau.SetActive(true);
            foreach (DragNDrop draggable in dragObjects)
            {
                if (!draggable.IsSnapped())
                {
                    draggable.gameObject.SetActive(true);
                }
            }
        }
    }

    // 0 : mode UX
    // 1 : mode UI
    public void SwitchMode()
    {
        Debug.Log(currentM);
        if (currentM == 0)
        {
            currentM = 1;
            controller.SetMode(1);
        }
        else if (currentM == 1)
        {
            currentM = 0;
            controller.SetMode(0);
        }
        else
        {
            currentM = 0;
            controller.SetMode(0);
        }
    }
}
