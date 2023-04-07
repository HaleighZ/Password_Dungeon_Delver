using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal_Key : MonoBehaviour
{
    [SerializeField] private KeyType keyType;
    public enum KeyType{
        Tutorial,
        BruteTutorial,
        Brute
    }

    //Returns KeyType (Brute, Dictionary, Rainbow)
    public KeyType GetKeyType(){
        return keyType;
    }
}
