using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour
{
    public int objectiveNumber;

    public GameObject objectif;
    public void Interact()
    {
        if(objectiveNumber == GameManager.objectivesDone)
        {
            Debug.Log(GameManager.objectivesDone);
            GameManager.objectivesDone++;
            Debug.Log(GameManager.objectivesDone);
            PlayerPrefs.SetInt("Objectif", GameManager.objectivesBeforeDeath += 1);
            objectif.SetActive(true);
        }
        else
        {
            Debug.Log("Nope");
        }
        
    }
  
}
