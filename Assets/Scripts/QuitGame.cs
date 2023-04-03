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
        Time.timeScale = 1.0f;
        gameObject.SetActive(false);
    }
}
