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

//Returns level type (1,2,3)
public Level_Type.LevelType GetLevelType() {
        return levelType;
    }
    
//Uses SceneManager to load new scene
public void ChangeScene(string level){
    SceneManager.LoadScene(level);
    
    }
public void LoadScene(){
    SceneManager.LoadScene(saveMan.data.levelName);
}


}


