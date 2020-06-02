using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPath : MonoBehaviour
{
    public NavMeshAgent agent;

    public GameObject destination1;
    public GameObject destination2;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(destination1.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destination1"))
        {
            agent.SetDestination(destination2.transform.position);
        }

        if (other.CompareTag("Destination2"))
        {
            agent.SetDestination(destination1.transform.position);
        }
    }
}
