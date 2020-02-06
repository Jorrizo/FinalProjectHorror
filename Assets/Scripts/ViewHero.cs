using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ViewHero : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform player;
    public float state;
    
    void Start()
    {
        state = 0;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }

    
}
