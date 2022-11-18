using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent navMeshAsgent;
    private Vector3 playerPos;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAsgent=GetComponent<NavMeshAgent>();
        player= GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos=player.transform.position;
        navMeshAsgent.destination=playerPos;
    }
}
