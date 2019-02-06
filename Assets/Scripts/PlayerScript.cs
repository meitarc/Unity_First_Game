using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
    public int boatLive;
    public int playerSpeed;
    public static int playerLives=3;
    public Camera playerCamera;
    public static int playerScore;
    public GameObject bulletPrefab;
    public AudioClip coinSound;
    public static int keys;
    public GameObject nextLevel;
    public static bool chestOpen = false;

    public Text text_score;
    public Text text_live;
    public Text text_boatLive;
    public GameObject img_key;
    public GameObject img_boat;
    public GameObject txt_boat;
    // Use this for initialization
    void Start () {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            playerLives = 3;
            playerScore = 0;
            boatLive = 15;
            keys = 0;
        }
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            img_boat.SetActive(true);
            txt_boat.SetActive(true);
        }
        else
        {
            img_boat.SetActive(false);
            txt_boat.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        text_score.text = playerScore.ToString();
        text_live.text = playerLives.ToString();
        text_boatLive.text = boatLive.ToString();

        if(keys>0)
        {
            img_key.SetActive(true);
        }
        else
        {
            img_key.SetActive(false);
        }

        if (playerLives < 1)
        {
            SceneManager.LoadScene(7);
        }

        if (transform.position.y>585f && SceneManager.GetActiveScene().buildIndex == 6)
        {
            SceneManager.LoadScene(8);
        }

        if (chestOpen)
        {
            keys = 0;
            nextLevel.SetActive(true);
            chestOpen = false;
        }
        float amtToMove = playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        //transform.Translate(Vector3.right*amtToMove);

        GetComponent<Transform>().Translate(Vector3.right * amtToMove);
        if(Input.GetKeyDown(KeyCode.Mouse0)&& SceneManager.GetActiveScene().buildIndex != 6)
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;
        }

        if(SceneManager.GetActiveScene().buildIndex == 2&&transform.position.y<-100)
        {
            playerLives--;
            transform.position = new Vector3(19.48f, 24.13f, 117.6f);
        }
        if(boatLive<1)
        {
            playerLives--;
            boatLive = 15;
        }
    }
    //void OnGUI()
    //{
    //    GUI.Label(new Rect(90, 40, 300, 20), "Score: " + playerScore);
    //    GUI.Label(new Rect(90, 50, 300, 20), "Lives: " + playerLives);
    //    GUI.Label(new Rect(90, 60, 300, 20), "Boat live: " + boatLive);
    //    GUI.Label(new Rect(90, 70, 300, 20), "Keys: " + keys);
    //}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Next_Level")
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene(2);
            }
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(3);
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene(4);
            }
            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                SceneManager.LoadScene(5);
            }
            if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                SceneManager.LoadScene(6);
            }
        }
        if (other.gameObject.tag == "Zombie")
        {
          
            transform.position = new Vector3(1.504f, 0.66f, -38.874f);
            playerLives--;
        }
        if (other.gameObject.tag == "Monster")
        {

            transform.position = new Vector3(40.75172f, 1.06f, -41.87536f);
            playerLives--;
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
        if (other.gameObject.tag == "key")
        {
            keys=1;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(other.gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")
        {
            playerScore += 10;
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(other.gameObject);
        }
    }
    public void BoatHurt()
    {
        boatLive--;

    }

    public void isTriger(Collider other)
    {
        OnTriggerEnter(other);
    }
}
