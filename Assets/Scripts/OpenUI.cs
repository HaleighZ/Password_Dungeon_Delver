using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    public GameObject UI;
    // Start is called before the first frame update
    void openTheUI(){
        UI.SetActive(true);
    }
}
