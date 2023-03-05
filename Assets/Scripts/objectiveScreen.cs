using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class objectiveScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI pressD, pressA, pressSpace, pressF, continuing; //Variables for the textboxes

    void Start()    //Sets only the textbox for pressing a to turn on. 
    {
       pressD.enabled = false;
       pressA.enabled = true;
       pressSpace.enabled = false;
       pressF.enabled = false;
       continuing.enabled = false;
    }

    // Update is called once per frame
    void Update() // Goes in order of pressA --> pressD --> pressSpace --> press F. This is when the player presses the buttons in that order. 
    {
        if (pressA.enabled == true &&Input.GetKey("a") )
        {
            pressA.enabled = false;
            pressD.enabled = true;
        }
        else if ((pressD.enabled == true) && Input.GetKey("d"))
        {
            pressD.enabled = false;
            pressSpace.enabled = true;
        }
        else if ((pressSpace.enabled == true) && Input.GetKey("space"))
        {
            pressSpace.enabled = false;
            pressF.enabled = true;
        }
        }
    }


