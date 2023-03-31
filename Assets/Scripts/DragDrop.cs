using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IInitializePotentialDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    [SerializeField] private Canvas canvas; //Grab the parent canvas of the group for this

    //Grabs the RectTransform of the item you are dragging and the CanvasGroup it's in
    private void Awake() { 
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    //As the user begins dragging the item, 
    //it will turn slightly transparent as well as disabling the blocking of raycasts,
    //this allows it to see anything under the object like the slots for the blocks
    public void OnBeginDrag(PointerEventData eventData){ 
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
        //Debug.Log("OnBeginDrag");
    }

    //Enables blocking of raycasts again when the user is done dragging the item,
    //Also makes the draggable object fully opaque again on letting go
    public void OnEndDrag(PointerEventData eventData){
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        //Debug.Log("OnEndDrag");
    }

    //Moves the draggable object with respect to the cursor
    //Divides by Canvas scale factor to avoid issues with different screen sizes
    public void OnDrag(PointerEventData eventData){
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        //Debug.Log("OnDrag");
    }

    //Checks if the pointer is clicked down on an object, will probably remove later
    public void OnPointerDown(PointerEventData eventData){
        //Debug.Log("OnPointerDown");
    }

    //Removes Drag threshold to avoid issues with minimum drag distance
    public void OnInitializePotentialDrag(PointerEventData eventData){
        eventData.useDragThreshold = false;
    }

    
}
