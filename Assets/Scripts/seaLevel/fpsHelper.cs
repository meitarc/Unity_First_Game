using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsHelper : MonoBehaviour
{
    public PlayerScript playerScript;

    public void OnTriggerEnter(Collider other)
    {
        playerScript.isTriger(other);
    }

}
