using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedlingDisplay : MonoBehaviour {
    public static int Seedlings = 0;
    Text text;
    public GameObject player;

    // Use this for initialization
   void Start()
    {
        
        
    }
    void Awake () {
        text = GetComponent<Text>();
        
    }
	
	// Update is called once per frame
	void Update () {
        Seedlings = player.GetComponent<SeedlingCollection>().points;
        text.text = "Seedlings Collected: " + Seedlings;
    }
}
