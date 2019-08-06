using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using System;

public class SaveAndLoad  {
    public static string path = "/playerInfo.sav";
    public static string folder = "Saves";
    public static int stageNum;

	
    
	


   
    public static void Save(int stagenum)
    {
        stageNum=stagenum;
        Debug.Log(stageNum);
        BinaryFormatter bf = new BinaryFormatter();//used to serialize the information
        FileStream file = File.Create(folder+path);//opens up file that exists called "playerInfo.txt
        //creates new player data object so we can use Player Data class methods
        bf.Serialize(file, stageNum);//serializes data for safe keeping using binary formatter
        file.Close();
    }

    public static int Load()
    {
        
        if (File.Exists(folder + path))//checks if saved file exists
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(folder + path, FileMode.Open);
           stageNum = (int)bf.Deserialize(file);//deserializes info to use in code and casts to PlayerData object
            file.Close();
            Debug.Log(stageNum);
            return stageNum;
            
        }
        return -1;
    }
    
}
