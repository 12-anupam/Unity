using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public player_movement movement;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacles")
        {
            movement.isCollided = true;
            movement.enabled = false;
            Debug.Log("Player got hit");
            anim.enabled = false;


        }


    }



}
