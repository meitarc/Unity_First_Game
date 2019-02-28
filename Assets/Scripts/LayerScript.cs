using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerScript : MonoBehaviour {

    bool flag = false; 
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        // This casts a ray that ignores both layers 2 and 8:
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        int layerMask = (1 << 8); // (1 << 2) | (1 << 8);
                                  // layerMask = ~layerMask;
        if (Physics.Raycast(ray, out hit, 100, layerMask)&& !flag)
        {
            // some code if the ray hits
            hit.collider.GetComponent<Renderer>().material.color = Color.red;

        }



    }
}
