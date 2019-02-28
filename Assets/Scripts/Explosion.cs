﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject bomb;
    public float power = 10.0f;
    public float radius = 5.0f;
    public float upForce = 1.0f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (bomb == enabled)
        {
            Invoke("Detonate", 0);
        }
    }

    void Detonate()
    {
        Vector3 explosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach(Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if(rb!=null)
            {
                rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
            }
        }
    }
}
