using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    public GameObject monstre;
    public GameObject[] lights;

    public static int objectivesDone;

    public static int objectivesBeforeDeath;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        objectivesBeforeDeath = PlayerPrefs.GetInt("Objectif", 0);
        objectivesDone = objectivesBeforeDeath;
        Debug.Log(objectivesBeforeDeath);      
             
        if(objectivesDone != 0)
        {
            monstre.SetActive(true);
            for(int i=0; i<= lights.Length; i++)
            {
                lights[i].SetActive(true);
            }
        }
    }

}
