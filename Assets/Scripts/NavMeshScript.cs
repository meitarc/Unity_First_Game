﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshScript : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("PlayerBoat").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

    }
}
