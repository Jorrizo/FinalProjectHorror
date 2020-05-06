using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    public static int objectivesDone;

    public Transform player;
    public Transform Spawnpoint1;
    public Transform Spawnpoint2;
    
    [HideInInspector]
    public static int objectivesBeforeDeath;

    void Start()
    {
       // PlayerPrefs.DeleteAll();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        objectivesBeforeDeath = PlayerPrefs.GetInt("Objectif", 0);
        objectivesDone = objectivesBeforeDeath;
        Debug.Log(objectivesBeforeDeath);
        /*if (objectivesBeforeDeath == 0)
        {
            player = Spawnpoint1;
        }
        if (objectivesBeforeDeath > 0)
        {
            player = Spawnpoint2;
        }*/
    }

}
