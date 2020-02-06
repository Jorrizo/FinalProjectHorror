﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImovement : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject destination;

    void Start()
    {
        agent.SetDestination(destination.transform.position);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Destination"))
        {
            Debug.Log("Cool, je suis arrivé");
        }
    }
}
