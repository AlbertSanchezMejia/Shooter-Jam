using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeguirPlayer : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    float speed = 18f;
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        enemy.speed = speed;
    }
    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
