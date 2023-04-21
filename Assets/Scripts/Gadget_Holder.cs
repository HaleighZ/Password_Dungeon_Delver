using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Gadget_Holder : MonoBehaviour
{
    private List<Terminal_Key.KeyType> keyList;
    public TextMeshProUGUI pressesF, continues;    //The text box used to access key.
    private bool pressingMenuKey = false;

    public float TimeScale = 1.0f;
    private void Awake() {
       
        keyList = new List<Terminal_Key.KeyType>(); //Instantiates a new keyList to add keys onto
         //Grabs component that has the objectiveScreen script with the variable pressF
    }

    void Update(){
        if (Input.GetKeyDown("f")) { pressingMenuKey = true; }
        if(Input.GetKeyUp("f")) { pressingMenuKey=false; }
        Time.timeScale = TimeScale;
    }

    //Adds the specific key to the Player's keyList
    public void addKey(Terminal_Key.KeyType keyType){
        Debug.Log("Added key!");
        keyList.Add(keyType);
    }
    //Checks what key the terminal is holding
    public bool ContainsKey(Terminal_Key.KeyType keyType){
        return keyList.Contains(keyType);
    }

    //Checks when the Player's Collision box collides with other specific colliders
    private void OnTriggerStay2D(Collider2D collider){
        //If the Player collider is colliding with the one of a Terminal_Key script holder
        Terminal_Key term_key = collider.GetComponent<Terminal_Key>();
        if(term_key != null){
            if(term_key.tag == "First_Tutorial_Console"){
                //If they press 'F' while in the collider, they will add a key to themself
                if (pressingMenuKey){ 
                    addKey(Terminal_Key.KeyType.Tutorial);
                    if (pressesF.enabled == true){
                        pressesF.enabled = false; //When the gadget console is accessed, turns off the text box. Then enables the continues textbox
                        continues.enabled = true; 
                    }
                }
            }
        }

        //If the Player collider is colliding with one of a Key_Door script holder, and the key type matches, it will open the door
        Key_Door key_door = collider.GetComponent<Key_Door>();
        if (key_door != null){
            if(ContainsKey(key_door.GetKeyType())){
                key_door.OpenDoor();
            }
        }

        //If the Player collider is colliding with one of a Level_Transition script holder,
        //It will grab the SaveManager and then check what the level type is before updating and writing to file 
        
        Level_Transition level_trans = collider.GetComponent<Level_Transition>();
        if (level_trans != null){
            
            SaveManager saveMan = collider.GetComponent<SaveManager>();
            if (saveMan != null){
            if(level_trans.GetLevelType() == Level_Type.LevelType.Level_1){
                level_trans.ChangeScene("Level_1");
                saveMan.updateLevel("Level_1");
                saveMan.SaveData();
                Debug.Log(saveMan.data.levelName);
                }
            if(level_trans.GetLevelType() == Level_Type.LevelType.Level_2){
                level_trans.ChangeScene("Level_2");
                saveMan.updateLevel("Level_2");
                saveMan.SaveData();
                Debug.Log(saveMan.data.levelName);
                }
            if(level_trans.GetLevelType() == Level_Type.LevelType.TitleScreen){
                level_trans.ChangeScene("TitleScreen");
                saveMan.updateLevel("Level_1");
                saveMan.SaveData();
                }
            }
        }

        //If they press 'F' while in the collider, they will open the UI
        OpenUI openUI = collider.GetComponent<OpenUI>();
        if (openUI != null){
            if (pressingMenuKey){ 
                openUI.UI.SetActive(true); 
                
            }
        }

    }
    
}

