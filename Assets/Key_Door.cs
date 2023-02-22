using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Door : MonoBehaviour
{
    [SerializeField] private Terminal_Key.KeyType keyType;

    public Terminal_Key.KeyType GetKeyType() {
        return keyType;
    }

    public void OpenDoor(){
        gameObject.SetActive(false);
    }
}
