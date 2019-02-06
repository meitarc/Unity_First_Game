using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootScript : MonoBehaviour
{

    public GameObject player;
    public BulletEScript bullet;
    public float timer;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerBoat");
        InvokeRepeating("Shoot", timer, timer);
    }
    private void Update()
    {
        transform.LookAt(player.transform.position);
    }
    void Shoot()
    {
        GameObject bulletObject = Instantiate(bullet.gameObject);
        bulletObject.transform.position = transform.position + transform.forward;
        bulletObject.transform.forward = transform.forward;
    }
}
