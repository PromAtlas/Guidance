using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMainMenu : MonoBehaviour
{
    public enum Menu
    {
        MainMenu,
        NewGame,
        Continue
    }
    int stageNum;
    public Menu currentMenu = Menu.MainMenu;
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();
        
            GUILayout.Box("Guidance");

            GUILayout.Space(10);

            if (SaveAndLoad.Load() == -1)
                GUILayout.Box("You have no saves!");

            else
            {
                GUILayout.Box("Pick a Save!");
                GUILayout.Space(10);

                if (GUILayout.Button("Stage number: " + (SaveAndLoad.Load() - 1)))
                {
                    SceneManager.LoadScene(SaveAndLoad.Load());
                }



               
            }

        GUILayout.Space(10);
        if (GUILayout.Button("Quit"))
        {
            SceneManager.LoadScene(0);

        }


        GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        
    }
}
