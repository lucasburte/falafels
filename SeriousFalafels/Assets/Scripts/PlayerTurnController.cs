using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnController : MonoBehaviour
{
    [SerializeField]
    private int currentMode = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetMode() {
        return currentMode;
    }

    public void SetMode(int newMode) {
        currentMode = newMode;
    }
}
