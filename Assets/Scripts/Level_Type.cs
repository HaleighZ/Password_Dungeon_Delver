using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Type : MonoBehaviour
{
    [SerializeField] private LevelType levelType;
    public enum LevelType{
        Level_1,
        Level_2,
        Level_3
    }

    public LevelType GetLevelType(){
        return levelType;
    }   
}
