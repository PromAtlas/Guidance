﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void NewGame()
    {
        SaveAndLoad.Save(2);
        SceneManager.LoadScene(2);
        
    }
    public void ExitGame()
    {
        Application.Quit();

    }
    public void LoadByIndex ()
    {
        SceneManager.LoadScene(1);
    }
}
