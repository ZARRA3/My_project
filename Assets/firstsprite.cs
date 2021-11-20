using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstsprite : MonoBehaviour
{
    // Start is called before the first frame update
    public Text myText;
    void Start()
    {
        Debug.Log("Hello World!");
        myText.text = "Hello World!";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello Update !");
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
    }
}
