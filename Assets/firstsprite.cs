using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstsprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello Update !");
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
    }
}
