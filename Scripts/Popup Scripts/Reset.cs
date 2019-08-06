using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Reset : MonoBehaviour {
    

    void Start ()
    {
        
	}
	
	void Update ()
    {
		
	}
    public void ResetButtonFunction()
    {
        SceneManager.LoadScene(SaveAndLoad.Load());
    }

    public void nextLevel()
    {
        SaveAndLoad.Save(SaveAndLoad.Load()+1);
        SceneManager.LoadScene(SaveAndLoad.Load());
    }
}
