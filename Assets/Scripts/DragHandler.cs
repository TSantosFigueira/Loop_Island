using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;
    private static bool IsDraggable = true;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        IsDraggable = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        IsDraggable = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        IsDraggable = true;
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
    }

    public static bool Draggable()
    {
        return IsDraggable;
    }
}
