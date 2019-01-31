using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchModeScript : MonoBehaviour
{

    public GameObject boat;
    public GameObject boatCamera;
    public GameObject player;
    public GameObject playerStartPos;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //set to boat mode//
        if (Input.GetKey("1"))
        {
            boat.GetComponent<Rigidbody>().isKinematic = false;
            boat.GetComponent<BoatScript>().enabled = true;
            boatCamera.SetActive(true);
            player.SetActive(false);

        }

        //set to FPS mode//
        if (Input.GetKey("2"))
        {
            boat.GetComponent<Rigidbody>().isKinematic = true;
            boat.GetComponent<BoatScript>().enabled = false;
            boatCamera.SetActive(false);
            player.SetActive(true);
            player.transform.position = playerStartPos.transform.position;


        }


    }
}
