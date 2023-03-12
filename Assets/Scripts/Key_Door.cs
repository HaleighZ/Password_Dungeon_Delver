using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Door : MonoBehaviour
{
    [SerializeField] private Terminal_Key.KeyType keyType;

    //Checks to see the keytype needed
    public Terminal_Key.KeyType GetKeyType() {
        return keyType;
    }

    //Currently just deletes the door. Will eventually be replaced with an actual animation
    public void OpenDoor(){
        gameObject.SetActive(false);
    }
}
