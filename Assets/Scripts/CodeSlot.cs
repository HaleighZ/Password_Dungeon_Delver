using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CodeSlot : MonoBehaviour, IDropHandler
{
    //This will snap the dragged object into the center of this slot object when it is overlapping upon EndDrag
    public void OnDrop(PointerEventData eventData){
        if(eventData.pointerDrag != null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
