using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIwaypoint : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] waypoint;
    private int random;


    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(waypoint[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        random = Random.Range(0, 7);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destination1"))
        {
            random = Random.Range(0, 10);
            if (random <= 5)
            {
                agent.SetDestination(waypoint[1].position);
            }
            else
            {
                agent.SetDestination(waypoint[2].position);
            }
        }

        if (other.gameObject.CompareTag("Destination2"))
        {
            random = Random.Range(0, 10);
            if (random <= 5)
            {
                agent.SetDestination(waypoint[2].position);
            }
            else
            {
                agent.SetDestination(waypoint[3].position);
            }
            
        }

        if (other.gameObject.CompareTag("Destination3"))
        {
            random = Random.Range(0, 10);
            if (random <= 5)
            {
                agent.SetDestination(waypoint[0].position);
            }
            else
            {
                agent.SetDestination(waypoint[3].position);
            }
        }

        if (other.gameObject.CompareTag("Destination4"))
        {
            random = Random.Range(0, 10);
            if (random <= 5)
            {
                agent.SetDestination(waypoint[0].position);
            }
            else
            {
                agent.SetDestination(waypoint[1].position);
            }
        }
    }
}
