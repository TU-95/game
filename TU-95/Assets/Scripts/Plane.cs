using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{

    public float speed;
    public bool thrustState = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            thrustState = true;
            speed = 3f;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            thrustState = false;
            speed = 1f;
        }

        if(Input.GetKey("w"))
        {
            transform.Translate(Time.deltaTime * speed, 0, 0, Camera.main.transform);
        }

        if(Input.GetKey("a"))
        {
            transform.Translate(Time.deltaTime * speed, 0, 0, Camera.main.transform);
        }
    }
}