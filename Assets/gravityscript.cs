using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityscript : MonoBehaviour
{
    float gravity = 0f;
    public Vector2 speed;
    void Start()
    {
        Vector2 speed = new Vector2(1, 1);
        GetComponent<Rigidbody2D>().velocity = speed;
    }
    // Update is called once per frame
    void Update()
    {
        
        gravity = Input.GetAxis("Vertical3");
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}
