using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cdcd : MonoBehaviour
{
    public Transform B;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    void OnCollisionStay2D(Collision2D collider)
    {
        Debug.Log("good");
        if ( collider.gameObject.tag == "bbbbb" )
        {
            B.position = Vector3.MoveTowards(B.position, new Vector3(0, 1, 0), Time.deltaTime * 2);
            Debug.Log("good");
 
void OnCollisionExit2D(Collision2D collider){

        
            B.position = Vector3.MoveTowards(B.position, new Vector3(0, -1, 0), Time.deltaTime * 2);




        }


    }

}

}
