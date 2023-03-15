using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour
{
    private int currentMode;
    private PlayerTurnController controller;
    public delegate void DragEndDelegate(DragNDrop draggableObject);
    public DragEndDelegate dragEndedCallback; 
    private bool isDragged = false;
    private bool isSnapped = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;
    private Vector3 spriteInitPosition;

    private Vector3 GetMouseWorldPosition() {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }


    private void OnMouseDown() {
        if (currentMode == 0) {
            isDragged = true;
            mouseDragStartPosition = GetMouseWorldPosition();
            spriteDragStartPosition = transform.localPosition;
            SetSnapped(false);
        }
    }


    private void OnMouseDrag() {
        if (currentMode == 0) {
            if (isDragged) {
                transform.localPosition = spriteDragStartPosition + GetMouseWorldPosition() - mouseDragStartPosition;
                dragEndedCallback?.Invoke(this);
                SetSnapped(false);
            }
        }
    }


    private void OnMouseUp() {
        if (currentMode == 0) {
            isDragged = false;
            dragEndedCallback?.Invoke(this);
            if (!isSnapped) {
                ResetPosition();
            }
        }
    }


    private void Start() {
        controller = GameObject.FindWithTag("GameController").GetComponent<PlayerTurnController>();
        spriteInitPosition = transform.localPosition;
    }


    private void Update() {
        currentMode = controller.GetMode();
    }


    public void SetSnapped(bool snapped) {
        isSnapped = snapped;
    }

    public void ResetPosition() {
        transform.localPosition = spriteInitPosition;
    }

    public bool IsSnapped()
    {
        return isSnapped;
    }
}
