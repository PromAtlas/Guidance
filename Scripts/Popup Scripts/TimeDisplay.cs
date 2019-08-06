using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {
    int checkPointTime;
    Text text;
    bool timeSet = false;
   public GameObject player;
    // Use this for initialization
    private void Start()
    {
        
    }
    void Awake () {
        text = GetComponent<Text>();
       
	}
	
	// Update is called once per frame
	void Update () {
       
        if (!timeSet)
        {
            checkPointTime = (int)Time.time;
           

            timeSet = true;

        }
        text.text = "Time: " + checkPointTime + " Seconds";
	}
}
