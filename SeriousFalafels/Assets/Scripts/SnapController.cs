using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{
    public delegate void DragEndDelegate();
    public List<Transform> snapPoints;
    public List<DragNDrop> draggableObjects;
    [SerializeField]
    private float snapRange = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
