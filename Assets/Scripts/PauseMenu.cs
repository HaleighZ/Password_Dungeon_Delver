using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject panel; 
    private GameObject reveal;
    
    void Start()
    {
    panel = GameObject.FindGameObjectWithTag("Panel");
    panel.SetActive(false);
    }

    private void Update() {
        if(Input.GetKeyDown("p")){
            panel.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
    public void Pause()
    {
        Debug.Log("Printing");
        if (panel.activeInHierarchy == false){
            panel.SetActive(true);
        }else
        {
            panel.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
    public void Reveal(){
        if (reveal.activeInHierarchy == false){
            reveal.SetActive(true);
        }else
        {
            reveal.SetActive(false);
        }
    }
}
