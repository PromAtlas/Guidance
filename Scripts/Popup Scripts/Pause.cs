using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject pauseScreen;

	void Start () {
        pauseScreen.SetActive(false);
	}


    void Update() {
        if (Input.GetKeyDown(KeyCode.P))
        {

            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showScreen();
            }

            else
            {
                Time.timeScale = 1;
                hideScreen();
            }

        }

	}

    void showScreen()
    {
        pauseScreen.SetActive(true);
    }

    void hideScreen()
    {
        pauseScreen.SetActive(false);
    }
}
