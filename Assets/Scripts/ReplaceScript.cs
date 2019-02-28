using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceScript : MonoBehaviour
{
    public GameObject remain;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Instantiate(remain, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}