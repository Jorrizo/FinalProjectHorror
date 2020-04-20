using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestinationForMonster : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject destination;
    private Vector3 michel;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        michel = destination.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monster"))
        {
            Debug.Log("Cool, je suis arrivé");
            agent.SetDestination(michel);
        }

        
    }
}
