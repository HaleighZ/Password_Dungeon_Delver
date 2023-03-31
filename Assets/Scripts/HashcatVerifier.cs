using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class HashcatVerifier : MonoBehaviour
{
    GameObject[] objects = {null, null, null, null};
    public GameObject[] solution;
    
    void Start(){
        gameObject.SetActive(false);
    }

    public void Verify(){
        bool result = true;
        for (int i = 0; i < objects.Length; i++)
        {
            if(objects[i] != solution[i]){
                result = false;
            }
        }
        if(result == true){
            Debug.Log("You got it!");
        }

    }

    public void Store(GameObject data, int index){
        objects[index] = data;
    }
}
