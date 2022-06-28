using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoLift : MonoBehaviour
{
    public float speed = 1f;  //Speed value for lift pipes up

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (transform.up * speed * Time.deltaTime);  //Lift pipes up
    }
}
