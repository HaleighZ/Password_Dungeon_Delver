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

    public void SaveData(){
        string destinationFolder = Application.persistentDataPath+"/Test.json";

        if(!File.Exists(destinationFolder)){
            File.Create(destinationFolder);
        }

        FileStream fileThing = File.Open(destinationFolder, FileMode.Open);
        byte[] bytes = Encoding.UTF8.GetBytes(JsonUtility.ToJson(data));
        fileThing.Write(bytes);
        fileThing.Close();
    }

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

    public void updateLevel(string levelName){
        this.data.levelName = levelName;
    }

}
