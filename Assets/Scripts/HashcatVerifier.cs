using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class HashcatVerifier : MonoBehaviour
{
    //The array of the tiles of the player's arrangement
    GameObject[] objects = {null, null, null, null};
    //The array of the solution determined by the objects dragged into the component's GUI
    public GameObject[] solution;
    [SerializeField] Gadget_Holder gadget_Holder;
    [SerializeField] Terminal_Key terminal;

    //This UI will start hidden by default
    void Start(){
        gameObject.SetActive(false);
    }
    void Awake(){
        gadget_Holder = gadget_Holder.GetComponent<Gadget_Holder>();
        terminal = terminal.GetComponent<Terminal_Key>();
    }

    //This will iterate through the entire solution array of objects against the player's arrangement to see if it is correct
    //If it is correct, it will print a log. If not, it will currently do nothing.
    public void Verify(){
        bool result = true;
        for (int i = 0; i < objects.Length; i++){
            if(objects[i] != solution[i]){
                result = false;
            }
        }
        if(result == true){
            Debug.Log("You got it!");
            if(terminal.tag == "Tutorial_Console"){
                if(gadget_Holder == null){
                    Debug.Log("gadgetholder is null");
                }
                if(terminal == null){
                    Debug.Log("terminal is null");
                }
                gadget_Holder.addKey(terminal.GetKeyType());
                Debug.Log("You have received the BruteTutorial Key");
            }
            if(terminal.tag == "Door_Terminal"){
                gadget_Holder.addKey(terminal.GetKeyType());
                Debug.Log("You have received the Brute Key");
            }
        }
    }

    //Overwrites what object is stored in the player's array at that index when it is 'slotted in' by dragging it into place
    //Index is determined by what is inputted into the objects public int field with the Code Slot script attached
    public void Store(GameObject data, int index){
        objects[index] = data;
    }
}
