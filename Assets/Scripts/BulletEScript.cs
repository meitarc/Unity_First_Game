using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEScript : MonoBehaviour
{
    public int bulletSpeed = 10;
    public Transform explosion;
    public float speed = 8f;
    //public AudioClip sound;
    public float lifeDuration = 1000f;
    private float lifeTimer;

    public PlayerScript playerScript;
    // Use this for initialization
    void Start()
    {
        lifeTimer = lifeDuration;
        playerScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<PlayerScript>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.forward * speed * Time.deltaTime;
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }


    }

    //public void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.CompareTag("Player")|| other.gameObject.CompareTag("PlayerBoat"))
    //    {
    //        //AudioSource.PlayClipAtPoint(sound, transform.position);
    //        //PlayerScript.playerHurt();
    //        PlayerScript.playerLives--;
    //        //Instantiate(explosion, transform.position, Quaternion.identity);
    //    }
    //}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerBoat") || other.gameObject.CompareTag("Boat"))
        {
            if (playerScript != null)
                playerScript.BoatHurt();
        }
    }
}
