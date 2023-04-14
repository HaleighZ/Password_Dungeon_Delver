using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverCursor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //Each cell of the array will hold one of these structs where the tile you are hovering over and the text description are determined
    //by what is placed in the Inspector  
    [Serializable]
    public struct HoverText
    {
        public GameObject hovering;
        public GameObject text;

    }
    //Initiates the array and then at the start assigns the base description as the current one.
    public GameObject baseDesc;
    public HoverText[] hoverableArray;
    private GameObject current;

    void Start(){

        current = baseDesc;
    }
    //When they are no longer hovering their cursor over a specific tile it will disable it and then swap back to the baseDesc
    public void OnPointerExit(PointerEventData eventData){
        if(current != baseDesc){
            current.SetActive(false);
            current = baseDesc;
            current.SetActive(true);
        }
    }
    //When their cursor is hovering over a specific tile, it will look within the struct to see what text is assigned to that tile
    //it will then assign that description to current and display it. 
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(eventData.pointerEnter != current){
            foreach (HoverText Element in hoverableArray){
                if(eventData.pointerEnter == Element.hovering){
                    current.SetActive(false);
                    Element.text.SetActive(true);
                    current = Element.text;
                    break;
                }
            }
        }
    }
}
