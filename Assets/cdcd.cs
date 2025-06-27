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
        void OnCollisionExit2D(Collision2D collider)
        {

            if (collider.gameObject.tag == "bbbbb")
            {
                th = false;
            }
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


    
