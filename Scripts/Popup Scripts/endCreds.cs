using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endCreds : MonoBehaviour {

    void Start()
    {
        gameObject.SetActive(false);
    }

    
    void Update()
    {

    }
    public void ToggleLevelComplete()
    {
        gameObject.SetActive(true);

    }
}
