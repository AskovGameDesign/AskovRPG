using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleEnemy : MonoBehaviour
{
    public float targetViewLength = 10;
    [Range(0, 360)]
    public float targetViewAngle = 30;

    public Transform player;
    NavMeshAgent enemyAgent;

    // Start is called before the first frame update
    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(player.position);
    }
}
