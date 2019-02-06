using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpenScript : MonoBehaviour
{

    public AudioClip chestSound; //chest opening sound clip goes here
    public GameObject treasureChest; //treasure chest prefab goes here
    public bool isOpen = false;
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player" && !isOpen && PlayerScript.keys > 0)
        {
            PlayerScript.playerScore += 200;
            AudioSource.PlayClipAtPoint(chestSound, transform.position); //plays our soundclip

            treasureChest.GetComponent<Animation>().Play();//plays the default animation applied to our treasureChest model
            isOpen = true;

            PlayerScript.chestOpen = true;
        }

    }
}
