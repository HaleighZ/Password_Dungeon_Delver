using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Transition : MonoBehaviour
{
    [SerializeField] private Level_Type.LevelType levelType;

public Level_Type.LevelType GetLevelType() {
        return levelType;
    }
public void ChangeScene(string level){
    SceneManager.LoadScene(level);
    
    }
}
