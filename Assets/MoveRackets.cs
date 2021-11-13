using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRackets : MonoBehaviour
{
    //This is the speed of the racket mouvement
    public float speed = 30;
    public string Axis;
    void FixedUpdate ()
    {
        //this is our GetAxisRaw input
        float v = Input.GetAxisRaw(Axis)*speed;
        //Just calling the Rigidbody2D component to change its Velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
