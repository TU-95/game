using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{

    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            transform.Translate(Time.deltaTime * speed, 0, 0, Camera.main.transform);
        }

        if(Input.GetKey("w"))
        {
            transform.Translate(Time.deltaTime * speed, 0, 0, Camera.main.transform);
        }
    }
}
