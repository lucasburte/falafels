using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<DragNDrop> draggableObjects;
    [SerializeField]
    private float snapRange = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        foreach( DragNDrop draggable in draggableObjects) {
            draggable.dragEndedCallback = OnDragEnded;
        }
    }

    private void OnDragEnded(DragNDrop draggable) {
        float closestDistance = Mathf.Infinity;
        Transform closestSnapPoint = null;

        foreach(Transform snapPoint in snapPoints) {
            float currentDistance = Vector2.Distance(draggable.transform.localPosition, snapPoint.localPosition);
            if (currentDistance < closestDistance) {
                closestDistance = currentDistance;
                closestSnapPoint = snapPoint;
            }
        }

        if (closestSnapPoint != null && closestDistance < snapRange ) {
            draggable.transform.localPosition = closestSnapPoint.localPosition;
        }
    }
}
