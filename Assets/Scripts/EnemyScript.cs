using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public int enemySpeed=5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float amtToMove = enemySpeed * Time.deltaTime;
        transform.Translate(Vector3.down * amtToMove);
        if(transform.position.y<-5.6)
        {
            transform.position = new Vector3(Random.Range(-6f,6f),6,0);
        }


	}
}
