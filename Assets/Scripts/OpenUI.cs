using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    public GameObject UI;

    void openTheUI(){
        UI.SetActive(true);
    }
}
