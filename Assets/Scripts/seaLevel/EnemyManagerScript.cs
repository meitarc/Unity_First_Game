using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagerScript : MonoBehaviour
{
    //public PlayerScript playerHealth;       // Reference to the player's heatlh.
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 10f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.

    private GameObject player;
    //public float MinDistance = 15f;
    public int max = 10;
    private void Awake()
    {
        //player = playerHealth.gameObject;
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.

            InvokeRepeating("Spawn", spawnTime, spawnTime);

    }

    void Spawn()
    {
        // If the player has no health left...   || Vector3.Distance(player.transform.position,transform.position) > MinDistance
        //if (playerHealth.playerLives <= 0f)
        //{
        //    // ... exit the function.
        //    return;
        //}

        // Find a random index between zero and one less than the number of spawn points.

        if (max > 0)
        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);

            // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            max--;
        }
    }
}
