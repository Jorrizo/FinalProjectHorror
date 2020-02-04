using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImovement : MonoBehaviour
{

    [SerializeField] private NavMeshAgent NavMeshAgent;
    [SerializeField] private GameObject m_Target1;
    [SerializeField] private GameObject m_Target2;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent.SetDestination(m_Target2.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter(Collider : Collision)
    //{
        //if(Collision = tag"NavMeshAgent.SetDestination(m_Target1.transform.position);
    //z}
}
