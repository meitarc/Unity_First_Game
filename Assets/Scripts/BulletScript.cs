using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    public int bulletSpeed = 10;
    public Transform explosion;
    public float speed=8f;
    public AudioClip sound;
    public float lifeDuration = 2f;
    private float lifeTimer;
	// Use this for initialization
	void Start () {
        lifeTimer = lifeDuration;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.forward * speed * Time.deltaTime;
        lifeTimer -= Time.deltaTime;
        if(lifeTimer<=0f)
        {
            Destroy(gameObject);
        }


	}
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "Zombie"|| other.gameObject.tag == "Mushroom")
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            PlayerScript.playerScore += 100;
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
