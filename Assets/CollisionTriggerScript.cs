using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTriggerScript : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + "Has Collided with " + collision.gameObject.name);
        Debug.Log("Collision data" +collision.contacts[0].point.x);
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + "was trigger by " + other.gameObject.name);

    }
}
