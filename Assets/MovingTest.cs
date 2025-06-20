using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTest : MonoBehaviour
{

    private bool IsTouch = false;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (IsTouch) target.position = Vector2.MoveTowards(target.position, new Vector2(-2.93000007f, 1.17999995f), 2.0f * Time.deltaTime);
        else target.position = Vector2.MoveTowards(target.position, new Vector2(-2.48000002f,-0.50224936f), 2.0f * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Triangle") IsTouch = true;
    }
    
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name == "Triangle") IsTouch = false;
    }
}
