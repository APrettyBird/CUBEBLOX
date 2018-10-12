
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement; // A reference to our PlayerMovement script
    public AudioSource QuackSource;

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".

    void Start()
    {
        QuackSource = GetComponent<AudioSource>();
    }
 

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            QuackSource.Play();

            movement.enabled = false; // Disable the players movement.
            FindObjectOfType<GameManager>().EndGame();
          
        }
    
    }


}
