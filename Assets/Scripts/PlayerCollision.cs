using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("we hit Obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
