﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FirstScript : MonoBehaviour {


    public Text myText;
    public TextMeshProUGUI myTmpText;

	// Use this for initialization
	void Start () {
        myText.text = "alexhoedlmoser";
        myTmpText.text = "hello tmp text";
        Debug.Log("hello World");
  
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
