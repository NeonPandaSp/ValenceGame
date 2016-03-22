using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public void OnPointerEnter(PointerEventData eventData) {

    }

    public void OnPointerExit(PointerEventData eventData) {
    }

    public void OnDrop(PointerEventData eventData) {
        Debug.Log(eventData.pointerDrag.name +" was droped on to " + gameObject.name);

        DragHandler d = eventData.pointerDrag.GetComponent<DragHandler>();
        if (d != null) {
            d.parentToReturnTo = this.transform.FindChild("AgentList");
        }
    }


}
