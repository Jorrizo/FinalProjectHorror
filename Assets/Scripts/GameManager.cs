using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    public static int objectivesDone;

    public GameObject playerObject;

    public Transform SP1;
    public Transform SP2;

    public static Transform Spawnpoint1;
    public static Transform Spawnpoint2;
    
    public static int objectivesBeforeDeath;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        objectivesBeforeDeath = PlayerPrefs.GetInt("Objectif", 0);
        objectivesDone = objectivesBeforeDeath;
        Debug.Log(objectivesBeforeDeath);
        Spawnpoint1 = SP1;
        Spawnpoint2 = SP2;

        /*if(objectivesDone == 0)
        {
            Instantiate(playerObject, new Vector3(Spawnpoint1.position.x, Spawnpoint1.position.y, Spawnpoint1.position.z), Quaternion.identity);
        }
        else
        {
            Instantiate(playerObject, new Vector3(Spawnpoint2.position.x, Spawnpoint2.position.y, Spawnpoint2.position.z), Quaternion.identity);
        }*/
             
    }

}
