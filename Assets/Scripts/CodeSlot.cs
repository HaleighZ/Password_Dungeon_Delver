using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CodeSlot : MonoBehaviour, IDropHandler
{
    public HashcatVerifier Verifier;

    //This will need to be inputted via Unity GUI. Shouldn't need to be touched from prefab.
    public int index;
    
    public void OnDrop(PointerEventData eventData){
        if(eventData.pointerDrag != null){
            //This will snap the dragged object into the center of this slot object when it is overlapping upon EndDrag
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            
            //This will store the entire data from the object being dragged into the verifier array, it will overwrite anything there previously
            Verifier.Store(eventData.pointerDrag, index);
        } 
    }
    
}
