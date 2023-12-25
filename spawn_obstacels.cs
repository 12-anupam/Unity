using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_obstacels : MonoBehaviour
{
    public GameObject Obstacles2;
    private Transform spawnpoint;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "spawnpoint")
        {
            Vector3 spawnpoint = new Vector3(transform.position.x, (float)-0.91,(float)0);
            Instantiate(Obstacles2, spawnpoint, Quaternion.identity);
        }
    }

   
}
