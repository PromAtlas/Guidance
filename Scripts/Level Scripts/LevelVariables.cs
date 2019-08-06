using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelVariables : MonoBehaviour {
    public DeathMenu death;
    float checkPointTime;
    int health;
    void Start()
    {
        health = 100;

    }

    void Update()
    {

        if (GetComponent<SeedlingCollection>().points != GetComponent<SeedlingCollection>().TotalSeedlings)
        {
            checkPointTime = Time.time;
        }

        
    }

    void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.tag == "Damage")
        {

            health-=40;
            if (health <= 0)
            {
                death.ToggleDeathMenu();
               
            }
            }

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 30, 100, 20), "HEALTH: " + health);
        GUI.Label(new Rect(10, 50, 100, 20), "TIME: " + (int)checkPointTime);

    }
}
