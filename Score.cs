using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int score = 0;
    public Text scoretext;
    public player_movement playerGameobject;

    void Start()
    {
        playerGameobject = GameObject.FindWithTag("Player").GetComponent<player_movement>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerGameobject.score = playerGameobject.score + 1;
            Debug.Log("Score: " + playerGameobject.score);
        }
    }
}
