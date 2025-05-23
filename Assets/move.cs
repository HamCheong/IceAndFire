using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
float ymove = Input.GetAxisRaw("Vertical")*5*Time.deltaTime;
float xMove = Input.GetAxisRaw("Horizontal")*5*Time.deltaTime;
      this.transform.Translate(new Vector3(xMove,ymove,0));



   
    }
}
