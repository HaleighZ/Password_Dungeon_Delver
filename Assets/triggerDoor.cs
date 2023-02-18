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

    

    // Start is called before the first frame update
    void Start()
    {
        Using = false;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("f")){
            Using = true;
        }
        else{
            Using = false;
        }
    }
        void OnCollisionStay2D(BoxCollider2D col) {
            
            if(col.gameObject == player && Using){
                door.enabled = false;
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
    }
}
