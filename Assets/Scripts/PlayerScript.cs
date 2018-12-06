using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
    public int playerSpeed;

    public int playerLives;
    public Rigidbody bullet;

    public Camera playerCamera;

    public static int playerScore;

    public GameObject bulletPrefab;

    public AudioClip gameOverSound;
    public AudioClip coinSound;

    // Use this for initialization
    void Start () {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            playerLives = 3;
            playerScore = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (playerLives < 1)
        {
            SceneManager.LoadScene(3);
        }
        if(playerScore>1450 && SceneManager.GetActiveScene().buildIndex==1)
        {
            SceneManager.LoadScene(2);
        }
        if (playerScore > 2500 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(4);
        }

        float amtToMove = playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        //transform.Translate(Vector3.right*amtToMove);

        GetComponent<Transform>().Translate(Vector3.right * amtToMove);
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            playerScore += 100;
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(90, 40, 300, 20), "Score: " + playerScore);
        GUI.Label(new Rect(90, 50, 300, 20), "Lives " + playerLives);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zombie")
        {
            playerLives--;
            transform.position = new Vector3(1.504f, 0.66f, -38.874f);

        }

        if (other.gameObject.tag == "coin")
        {
            playerScore+=25;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag== "Mushroom")
        {
            playerLives--;
            transform.position = new Vector3(19.48f, 24.13f, 117.6f);

        }
        if (other.gameObject.tag == "heart")
        {
            playerLives++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(other.gameObject);
        }
    }
}
