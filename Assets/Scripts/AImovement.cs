using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AImovement : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform player;
    public GameObject agentPos;
    public int state;
    public float timer;
    public float timerSearch;
    private float timerDeath;
    private int destinationId;

    private Vector3 forward;
    private Vector3 right;
    private Vector3 left;
    private Vector3 extremRight;
    private Vector3 extremLeft;
    private Vector3 extremRightRight;
    private Vector3 extremLeftLeft;
    private Vector3 almostRight;
    private Vector3 almostLeft;
    private Vector3 toLeft;
    private Vector3 toRight;
    private Vector3 realLeft;
    private Vector3 realRight;
    private Vector3 behindRight;
    private Vector3 behindLeft;
    private Vector3 extremBehindRight;
    private Vector3 extremBehindLeft;
    private Vector3 extremBehindLeftLeft;
    private Vector3 extremBehindRightRight;
    private Vector3 almostBehindRight;
    private Vector3 almostBehindLeft;
    private Vector3 behind;

    void Start()
    {
        //Fonctionnement
        agent = GetComponent<NavMeshAgent>();
        state = 0;
        timer = 10f;
        timerSearch = 10f;
        timerDeath = 2;
    }

    void Update()
    {
        RaycastHit hit;

        forward = agentPos.transform.TransformDirection(Vector3.forward);
        right = agentPos.transform.TransformDirection(0.5f, 0, 3);
        left = agentPos.transform.TransformDirection(-0.5f, 0, 3);
        extremRight = agentPos.transform.TransformDirection(1, 0, 3);
        extremLeft = agentPos.transform.TransformDirection(-1, 0, 3);
        extremLeftLeft = agentPos.transform.TransformDirection(-1, 0, 1.5f);
        extremRightRight = agentPos.transform.TransformDirection(1, 0, 1.5f);
        almostLeft = agentPos.transform.TransformDirection(-2, 0, 1.5f);
        almostRight = agentPos.transform.TransformDirection(2, 0, 1.5f);
        toRight = agentPos.transform.TransformDirection(3, 0, 1);
        toLeft = agentPos.transform.TransformDirection(-3, 0, 1);
        realRight = agentPos.transform.TransformDirection(Vector3.right);
        realLeft = agentPos.transform.TransformDirection(Vector3.left);
        behindRight = agentPos.transform.TransformDirection(3, 0, -0.5f);
        behindLeft = agentPos.transform.TransformDirection(-3, 0, -0.5f);
        extremBehindRight = agentPos.transform.TransformDirection(3, 0, -1);
        extremBehindLeft = agentPos.transform.TransformDirection(-3, 0, -1);
        extremBehindRightRight = agentPos.transform.TransformDirection(2, 0, -1.5f);
        extremBehindLeftLeft = agentPos.transform.TransformDirection(-2, 0, -1.5f);
        almostBehindRight = agentPos.transform.TransformDirection(1, 0, -2);
        almostBehindLeft = agentPos.transform.TransformDirection(-1, 0, -2);
        behind = transform.TransformDirection(Vector3.back);

        Debug.DrawRay(transform.position, forward * 15, Color.red);
        Debug.DrawRay(transform.position, right * 5, Color.red);
        Debug.DrawRay(transform.position, left * 5, Color.red);
        Debug.DrawRay(transform.position, extremRight * 5, Color.red);
        Debug.DrawRay(transform.position, extremLeft * 5, Color.red);
        Debug.DrawRay(transform.position, extremLeftLeft * 8, Color.red);
        Debug.DrawRay(transform.position, extremRightRight * 8, Color.red);
        Debug.DrawRay(transform.position, almostLeft * 5, Color.red);
        Debug.DrawRay(transform.position, almostRight * 5, Color.red);
        Debug.DrawRay(transform.position, toLeft * 4, Color.red);
        Debug.DrawRay(transform.position, toRight * 4, Color.red);
        Debug.DrawRay(transform.position, realLeft * 12, Color.red);
        Debug.DrawRay(transform.position, realRight * 12, Color.red);
        Debug.DrawRay(transform.position, behindLeft * 1, Color.red);
        Debug.DrawRay(transform.position, behindRight * 1, Color.red);
        Debug.DrawRay(transform.position, extremBehindLeft * 1, Color.red);
        Debug.DrawRay(transform.position, extremBehindRight * 1, Color.red);
        Debug.DrawRay(transform.position, extremBehindLeftLeft * 1, Color.red);
        Debug.DrawRay(transform.position, extremBehindRightRight * 1, Color.red);
        Debug.DrawRay(transform.position, almostBehindLeft * 1, Color.red);
        Debug.DrawRay(transform.position, almostBehindRight * 1, Color.red);
        Debug.DrawRay(transform.position, behind * 2, Color.red);

        if (Physics.Raycast(transform.position, forward, out hit, 15))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, forward, out hit, 15))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, forward, out hit, 15))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, extremRight, out hit, 15))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, extremLeft, out hit, 15))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, extremLeftLeft, out hit, 24))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, extremRightRight, out hit, 24))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, almostLeft, out hit, 15))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, almostRight, out hit, 15))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, toLeft, out hit, 12))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, toRight, out hit, 12))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, realLeft, out hit, 36))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, realRight, out hit, 36))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, behindLeft, out hit, 1))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, behindRight, out hit, 1))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, extremBehindLeft, out hit, 1))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, extremBehindRight, out hit, 1))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, extremBehindRightRight, out hit, 1))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, extremBehindLeftLeft, out hit, 1))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, almostBehindRight, out hit, 1))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if (Physics.Raycast(transform.position, almostBehindLeft, out hit, 1))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }

        if(Physics.Raycast(transform.position, behind, out hit, 2))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("see you again");
                state = 1;
            }
        }
        // neutre
        if (state == 0)
        {
            Debug.Log("trop bien");
            agent.speed = 4;
        }

        // colère
        if(state == 1)
        {
            agent.SetDestination(player.position);
            timer -= Time.deltaTime;
            agent.speed = 10;
            agent.acceleration = 20;
        }
        
        // recherche
        if(state == 2)
        {
            timerSearch -= Time.deltaTime;
        }

        if(timer <= 0)
        {
            state = 0;
            timer = 20f;
        }

        if(timerSearch <= 0)
        {
            state = 0;
        }

        if(timerDeath<= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            timerDeath = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timerDeath -= 1 * Time.deltaTime;
        }
    }   
}
