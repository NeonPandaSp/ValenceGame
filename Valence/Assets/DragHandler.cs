using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    Vector3 startPos;
    
    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag: " + gameObject);

        startPos = this.transform.position;
    }

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("OnDrag: " + gameObject);

        Vector3 mouse = eventData.position;
        mouse.z = 30.0f;
        mouse = Camera.main.ScreenToWorldPoint(mouse);

        this.transform.position = mouse;

    }

    public void OnEndDrag(PointerEventData eventData) {

        Debug.Log("OnEndDrag: " + gameObject);

        this.transform.position = startPos;
    }
}
