using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsScript : MonoBehaviour {
    private Animator animator;
    private bool doorOpen;
	// Use this for initialization
	void Start () {
        doorOpen = false;
        animator = GetComponent<Animator>();
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            doorOpen = true;
            DoorControll("Open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorOpen = false;
            DoorControll("Close");
        }
    }

    private void DoorControll(string v)
    {
        animator.SetTrigger(v);
    }
}
