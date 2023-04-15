using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCapsuleController : MonoBehaviour
{
    public characterMovement characterMovement;

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = 0;
        if(Input.GetKey("a")){
            horizontalMove -= 1;
        }
        if(Input.GetKey("d")){
            horizontalMove += 1;
        }
        bool jump = Input.GetKeyDown("space");
        
        characterMovement.Move(horizontalMove,false,jump);
        
    }
}
