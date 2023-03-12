using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class triggerDoor : MonoBehaviour
{
    public BoxCollider2D door;
    private bool doorTrigger = true;
    public BoxCollider2D terminal;

    public BoxCollider2D player;

    private Animator animator;

    public bool Using;

    //THIS IS GOING TO BE REPURPOSED/REMOVED SOON

    // Start is called before the first frame update
    void Start()
    {
        Using = false;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        // if (Input.GetKeyDown("f")){
        //     if (doorTrigger){
        //         door.enabled = false;
        //     }
        //     else{
        //         door.enabled = true;
        //     }
        //     doorTrigger = !doorTrigger;
        // }
    }
    // void OnTriggerStay2D(Collider2D col){

    //     if(col.gameObject.tag == "Player"){

    //         if(Input.GetKey(KeyCode.F)){
    //         Using = !Using;

    //         if(Using){
    //         door.enabled = false;

    //         } 
    //         else{
    //         door.enabled = true;

    //         }

    //         }

    //     }

    // }
}

        // if (Input.GetKeyDown("f")){
        //     if (doorTrigger){
        //         door.enabled = false;
        //     }
        //     else{
        //         door.enabled = true;
        //     }
        //     doorTrigger = !doorTrigger;
        // }
