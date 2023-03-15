using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnController : MonoBehaviour
{
    [SerializeField]
    private int currentMode = 0;
    
    public int GetMode() {
        return currentMode;
    }
}
