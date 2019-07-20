using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;     // A reference to our PlayerMovement script

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.CompareTag("hamilton"))
        {
            GetComponent<PlayerMovement>().enabled = false;   // Disable the players movement.
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
