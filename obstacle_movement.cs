using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_movement : MonoBehaviour
{


    public Transform player;
    public float speed;
    public player_movement playerGameobject;

    void Start()
    {
        playerGameobject = GameObject.FindWithTag("Player").GetComponent<player_movement>();

    }
    void Update() // obstacle movement
    {
        if (playerGameobject.isCollided == false) { transform.Translate(Vector3.left * speed * Time.deltaTime); }

    }



}
