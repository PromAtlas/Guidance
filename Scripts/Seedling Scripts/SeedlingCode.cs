using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedlingCode : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        
        {
            Destroy(gameObject, 0.3f);
            AudioSource Source = GetComponent<AudioSource>();
            Source.Play();
            player.GetComponent<SeedlingCollection>().points++;


        }
    }
}
