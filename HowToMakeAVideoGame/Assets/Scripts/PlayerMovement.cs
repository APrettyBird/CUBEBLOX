using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;


    // We marked this as "Fixed"Update
    // are using it to mess with physics.
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // Add a forward Force
        rb.AddForce(0, 0, forwardForce *Time.deltaTime);

        if (Input.GetKey("d")) //If the player is pressing the "d" key
            // Add a force to the right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

	}
}
