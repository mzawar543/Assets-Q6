using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float startSpawn=2;
    private float repeatSpawn=1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnManager",startSpawn,repeatSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnManager()
    {
       Instantiate(enemyPrefab,gameObject.transform.position,gameObject.transform.rotation);
    }

}
