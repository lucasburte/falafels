using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour
{
    private bool isDragged = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;
    private Vector3 GetMouseWorldPosition() {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDown() {
        isDragged = true;
        mouseDragStartPosition = GetMouseWorldPosition();
        spriteDragStartPosition = transform.localPosition;
    }

    private void OnMouseDrag() {
        if (isDragged) {
            transform.localPosition = spriteDragStartPosition + GetMouseWorldPosition() - mouseDragStartPosition;
        }
        
    }

    private void OnMouseUp() {
        isDragged = false;
    }
}
