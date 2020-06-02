using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectif1 : MonoBehaviour
{
    public GameObject monster;
    public GameObject lights;

    void Start()
    {
        Debug.Log("itworksalso");      
        ActivateLights();
        MonsterSpawn();
    }

    public void ActivateLights()
    {
        lights.SetActive(true);
    }

    public void MonsterSpawn()
    {
        monster.SetActive(true);
        //ici pour sfx
    }
}
