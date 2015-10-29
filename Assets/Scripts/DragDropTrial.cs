using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragDropTrial : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 curScreenPoint;
    private Vector3 curPosition;
    private static bool dragging = true;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        dragging = false;
    }

    void OnMouseDrag()
    {
        curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
        dragging = false;
    }

    void OnMouseUp()
    {
        dragging = true;
    }

    public static bool isDragged()
    {
        return dragging;
    }
}
