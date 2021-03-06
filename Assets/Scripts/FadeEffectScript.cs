﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffectScript : MonoBehaviour {

    public Text hellText;
    public float fadeSpeed;
    public bool enterance;
    

	// Use this for initialization
	void Start () {
        hellText.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
        ColorChange();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"|| other.gameObject.tag == "PlayerBoat")
            enterance = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"||other.gameObject.tag == "PlayerBoat")
            enterance = false;
    }

    private void ColorChange()
    {
        if(enterance)
        {
            hellText.color = Color.Lerp(hellText.color, Color.white, fadeSpeed * Time.deltaTime);
        }
        else
        {
            hellText.color = Color.Lerp(hellText.color, Color.clear, fadeSpeed * Time.deltaTime);

        }

    }
}
