using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollScript : MonoBehaviour {
    public Transform[] waypoint;
    public float speed = 5;
    private int currentWpoint;
    Vector3 target, movedirection;
    private bool flag = true;    
	// Update is called once per frame
	void FixedUpdate () {
        target = waypoint[currentWpoint].position;
        movedirection = target - transform.position;

        if(movedirection.magnitude<1&&flag)
        {
            currentWpoint = ++currentWpoint%waypoint.Length;
            StartCoroutine(Stay());
        }
        GetComponent<Rigidbody>().velocity = movedirection.normalized * speed;
	}

    private IEnumerator Stay()
    {
        flag = false;
        yield return new WaitForSeconds(5);
        flag = true;
    }
}
