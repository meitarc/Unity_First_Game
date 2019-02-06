using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("OpenDoor");
    }
    private void OnTriggerExit(Collider other)
    {
        anim.enabled = true;
    }
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
