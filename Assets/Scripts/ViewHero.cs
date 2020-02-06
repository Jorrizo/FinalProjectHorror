using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ViewHero : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject hero;
    public Vector3 heroPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heroPosition = hero.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("je te vois chakal");
            agent.SetDestination(heroPosition);
        }
    }
}
