using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImovement : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject destination1;
    public GameObject destination2;
    public Transform player;
    public int state;
    public float timer;
    public float timerSearch;

    void Start()
    {
        state = 0;
        agent.SetDestination(destination1.transform.position);
        timer = 20f;
        timerSearch = 10f;
    }

    void Update()
    {
        // neutre
        if(state == 0)
        {
            agent.SetDestination(destination1.transform.position);
        }

        // colère
        if(state == 1)
        {
            agent.SetDestination(player.position);
            timer -= Time.deltaTime;
        }
        
        // recherche
        if(state == 2)
        {
            timerSearch -= Time.deltaTime;
        }

        if(timer <= 0)
        {
            state = 2;
            timer = 20f;
        }

        if(timerSearch <= 0)
        {
            state = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Destination"))
        {
            agent.SetDestination(destination2.transform.position);
            Debug.Log("Etat : Neutre");
        }

        if (other.gameObject.CompareTag("Player"))
        {
            state = 1;
            Debug.Log("Etat : Colère");
        }

    }

    
}
