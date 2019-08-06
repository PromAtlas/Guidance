using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedlingCollection : MonoBehaviour
{
    public int points = 0;
    public int TotalSeedlings;
    public LevelComplete CompleteScreen;
    public endCreds Credits;
    bool playOnce = true;
    public AudioClip Sound;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LevelWinCondition();
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "SEEDLINGS: " + points);

    }
    public void LevelWinCondition()
    {
        
        if (TotalSeedlings == points && playOnce && SaveAndLoad.Load() < 4)
        {
            AudioSource Song = GetComponent<AudioSource>();
            Song.PlayOneShot(Sound, .1f);
            CompleteScreen.ToggleLevelComplete();
            playOnce = false;
        }
        else if(TotalSeedlings == points && playOnce)
        {
            SaveAndLoad.Save(0);
            Credits.ToggleLevelComplete();
        }

    }
}

