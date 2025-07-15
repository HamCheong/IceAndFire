using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cdcd : MonoBehaviour
{
    public Transform B;
    // Start is called before the first frame update



    bool th = false;

    void OnCollisionEnter2D(Collision2D collider)
    {

        if (collider.gameObject.tag == "bbbbb")
        {
            th = true;
        }
        

    }

    void OnCollisionExit2D(Collision2D collider)
        {

            if (collider.gameObject.tag == "bbbbb")
            {
                th = false;
            }
        }



void Update()
{
 
 if(th == true)
 {

    B.position = Vector2.MoveTowards(B.position, new Vector2(-3.52999997f,2.8499999f),2.0f*Time.deltaTime);

 }else{
    B.position = Vector2.MoveTowards(B.position, new Vector2(-3.54999995f,0.930000007f),2.0f*Time.deltaTime);
 }



}
}


/* 예시
Void OnCollisionEnter2D (Collision2D collider)
{
	Debug.Log(collider.gameObject.transform.position);
}
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }
   



        }
        */


    
