using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody _rb;
    void Start()    {
        _rb = GetComponent<Rigidbody>();   
    }


    void Update()
    {
        Vector3 vel = _rb.velocity;
        if(Input.GetKey(KeyCode.RightArrow))
            _rb.velocity = new Vector3(3f, vel.y, vel.z);
        if(Input.GetKey(KeyCode.LeftArrow))
            _rb.velocity = new Vector3(-3f, vel.y, vel.z);
        if(Input.GetKey(KeyCode.Space))
            _rb.velocity = new Vector3(vel.x, 5f, vel.z);
    }
}
