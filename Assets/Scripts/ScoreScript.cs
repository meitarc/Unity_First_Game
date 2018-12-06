using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    GameObject myTextgameObject; // gameObject in Hierarchy
    Text ourComponent;           // Our refference to text component

    void Start()
    {
        // Find gameObject with name "MyText"
        myTextgameObject = GameObject.Find("ScoreText");
        // Get component Text from that gameObject
        ourComponent = myTextgameObject.GetComponent<Text>();
        // Assign new string to "Text" field in that component
        ourComponent.text = PlayerScript.playerScore.ToString();
    }
}
