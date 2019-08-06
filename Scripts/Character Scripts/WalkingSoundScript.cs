using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSoundScript : MonoBehaviour {

    public AudioClip sound;
    public AudioSource soundSource;
    float TimeToPlaySound;
   
    void Awake()
    {
        soundSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Time.time >= TimeToPlaySound)
        {
            play(1.3f);//passed value to now change pitch based on action being done
            TimeToPlaySound = Time.time + (sound.length/1.45f);//divided by 1.45 to reduce the length of that reflects the increased tempo
        }
       else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Time.time >= TimeToPlaySound)
        {
            play(1);
            TimeToPlaySound = Time.time + sound.length;//adds length of sound to current time, sound will not play until current time + sound length passes
        }
    }

    public void play(float pitchLevel)
    {
        soundSource.pitch=pitchLevel;//pitch actually alters both pitch and tempo, exactly what I wanted
        soundSource.PlayOneShot(sound, 1f);//quick method to play sound once

    }
}
