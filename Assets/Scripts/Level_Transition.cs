using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Transition : MonoBehaviour
{
    [SerializeField] private Level_Type.LevelType levelType;
    private SaveManager saveMan;

void Start(){
    saveMan = GetComponent<SaveManager>();
}

//Returns level type (1,2,TitleScreen)
public Level_Type.LevelType GetLevelType() {
        return levelType;
    }
    
//Uses SceneManager to load new scene
public void ChangeScene(string level){
    SceneManager.LoadScene(level); 
    }

//Uses the data in the JSON file to load the scene corresponding to that string. DO NOT REMOVE FROM SCENE MANAGER IN TITLE MENU
public void LoadScene(){
    SceneManager.LoadScene(saveMan.data.levelName);
    }

public void SwapScene(){
    SceneManager.LoadScene(levelType.ToString()); 
    }

}


