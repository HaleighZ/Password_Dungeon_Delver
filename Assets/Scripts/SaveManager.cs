using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class SaveManager : MonoBehaviour
{
    public DataHolder data;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TEST FUNCTIONS BELOW. WILL REMOVE THIS LATER.
        
        // if(Input.GetKeyDown("g")){
        //     SaveData();
        // }
        // if(Input.GetKeyDown("l")){
        //     LoadData();
        // }
        // if(Input.GetKeyDown("c")){
        //     data.levelName = "Level_1";
        // }
    }

    //Saves the name of the level into a JSON file that is rooted somewhere within the AppData folder
    //Tried changing the location to within the Assets folder upon first creation with bad results.
    //May revisit later.
    public void SaveData(){
        string destinationFolder = Application.persistentDataPath+"/Test.json";

        if(!File.Exists(destinationFolder)){
            File.Create(destinationFolder);
        }

        FileStream fileThing = File.Open(destinationFolder, FileMode.Open);
        byte[] bytes = Encoding.UTF8.GetBytes(JsonUtility.ToJson(data));
        fileThing.Write(bytes);
        fileThing.Close();
        Debug.Log("Saved Data");
    }

    //Reads the data from the JSON file (Level name) and makes it usable for other functions
    public void LoadData(){
        string destinationFolder = Application.persistentDataPath+"/Test.json";

        if(!File.Exists(destinationFolder)){
            Debug.LogError("File not found");
            return;
        }

        FileStream fileThing = File.Open(destinationFolder, FileMode.Open);
        byte[] bytes = new byte[fileThing.Length];
        fileThing.Read(bytes);
        fileThing.Close();

        DataHolder dataloader = new DataHolder();
        JsonUtility.FromJsonOverwrite(Encoding.UTF8.GetString(bytes), dataloader);
        
    }

    //Updates the name of the level stored within the ScriptableObject and JSON file
    public void updateLevel(string levelName){
        this.data.levelName = levelName;
    }

}
