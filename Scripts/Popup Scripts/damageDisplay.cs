﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class damageDisplay : MonoBehaviour {
    public static int damage;
    Text text;
    // Use this for initialization
    void Awake() {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Damage Taken: " + damage;
    }
}
