using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPosition : MonoBehaviour
{
    
    void Start()
    {
        if(GameManager.objectivesBeforeDeath == 0)
        {
            gameObject.transform.position = GameManager.Spawnpoint1.position;
            gameObject.transform.rotation = GameManager.Spawnpoint1.rotation;
        }
        else
        {
            gameObject.transform.position = GameManager.Spawnpoint2.position;
            gameObject.transform.rotation = GameManager.Spawnpoint2.rotation;
        }
    }

}
