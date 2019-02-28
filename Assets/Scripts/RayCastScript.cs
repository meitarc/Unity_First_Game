using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour {
    RaycastHit hit;
    public GameObject gameObject;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 5,Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                gameObject.SetActive(true);
                Destroy(GetComponent<Rigidbody>());
            }
        }
        else
        {
            gameObject.SetActive(false);
        }

	}
}
