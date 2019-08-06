using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ToggleLevelComplete()
    {
        gameObject.SetActive(true);
       
    }
}
