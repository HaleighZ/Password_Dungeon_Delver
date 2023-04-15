using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject panel; 
    
    void Start()
    {
    panel = GameObject.FindGameObjectWithTag("Panel");
    panel.SetActive(false);
    }

    private void Update() {
        if(Input.GetKeyDown("p")){
            panel.SetActive(true);
            FindObjectOfType<Gadget_Holder>().TimeScale = 0.0f;
        }
    }
    public void Pause()
    {
        if (panel.activeInHierarchy == false){
            panel.SetActive(true);
            
        }else
        {
            panel.SetActive(false);
            FindObjectOfType<Gadget_Holder>().TimeScale = 1.0f;
        }
    }
}
