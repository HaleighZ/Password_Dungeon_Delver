using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal_Key : MonoBehaviour
{
    [SerializeField] private KeyType keyType;
    public enum KeyType{
        Brute,
        Dictionary,
        RainbowTable
    }

    //Returns KeyType (Brute, Dictionary, Rainbow)
    public KeyType GetKeyType(){
        return keyType;
    }
}
