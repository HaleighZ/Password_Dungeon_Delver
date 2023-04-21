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
    [SerializeField] Gadget_Holder gadget_Holder; //Grabs the player's Gadget_Holder Script
    [SerializeField] Terminal_Key terminal; //Grabs the Terminal_Key script from the specific terminal
    [SerializeField] GameObject desc; //Grabs the current description of the UI
    [SerializeField] GameObject victory; //Grabs the victory message of the UI

    //This UI will start hidden by default
    void Start(){
        gameObject.SetActive(false);
    }
    private void Update() {
        if (gameObject.activeInHierarchy == true){
            FindObjectOfType<Gadget_Holder>().TimeScale = 0.0f;
        }    
    }
    void Awake(){
        gadget_Holder = gadget_Holder.GetComponent<Gadget_Holder>();
        terminal = terminal.GetComponent<Terminal_Key>();
    }

    //This will iterate through the entire solution array of objects against the player's arrangement to see if it is correct
    //If it is correct, it will disable the default message and set the victory message to active while giving the player the corresponding key
    public void Verify(){
        bool result = true;
        for (int i = 0; i < objects.Length; i++){
            if(objects[i] != solution[i]){
                result = false;
            }
        }
        if(result == true){

            if(terminal.tag == "Tutorial_Console"){
                gadget_Holder.addKey(terminal.GetKeyType());
                Debug.Log("You have received the BruteTutorial Key");
                desc.SetActive(false);
                victory.SetActive(true);
            }
            
            if(terminal.tag == "Door_Terminal"){
                gadget_Holder.addKey(terminal.GetKeyType());
                Debug.Log("You have received the Brute Key");
                desc.SetActive(false);
                victory.SetActive(true);
            }
        }
    }

    //Overwrites what object is stored in the player's array at that index when it is 'slotted in' by dragging it into place
    //Index is determined by what is inputted into the objects public int field with the Code Slot script attached
    public void Store(GameObject data, int index){
        objects[index] = data;
    }
}
