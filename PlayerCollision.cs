using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public player_movement movement;


    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacles")
        {
            movement.isCollided = true;
            movement.enabled = false;
            Debug.Log("Player got hit");


        }


    }



}
