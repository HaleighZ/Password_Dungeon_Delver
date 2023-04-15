using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    

    public void doExitGame() {
        Debug.Log("Exiting Game!");
        Application.Quit();
    }
    public void doExitUI(){   
        Debug.Log("Exit Menu!"); 
        gameObject.SetActive(false);
        FindObjectOfType<Gadget_Holder>().TimeScale = 1.0f;
    }
}
