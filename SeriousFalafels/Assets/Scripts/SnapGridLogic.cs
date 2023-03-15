using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapGridLogic : MonoBehaviour
{
    private int currentMode;
    private PlayerTurnController controller;
    private SpriteRenderer gridSpriteRend;
    private Sprite gridSprite;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindWithTag("GameController").GetComponent<PlayerTurnController>();
        gridSpriteRend = gameObject.GetComponent<SpriteRenderer>();
        gridSprite = gridSpriteRend.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        currentMode = controller.GetMode();
        switch (currentMode) {
            case 0:
                gridSpriteRend.sprite = gridSprite;
                break;
        
            case 1:
                gridSpriteRend.sprite = null;
                break;
            
            default:
                break;
        }
    }
}
