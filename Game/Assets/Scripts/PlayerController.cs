using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    public float gravityForce;
    public float xRange = -15f;
    public bool onGround = true;
    public bool gameOver = false;
    public bool hasPowerup = false;
    public GameObject powerupIndicator;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityForce;
    }

    // Update is called once per frame
    void Update()
    {
        // Gets the user input to move from side to side
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Makes the player be able to jump using the spacebar
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }

        // Keeps the player from falling off the platform by detecting if the player is beyond the xRange and stops the playing from moving beyound the xRange
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        powerupIndicator.transform.position = transform.position + new Vector3(0, 1.5f, 0);
    }

    // If the player picks up the powerup then it will destory itself and then will start the coroutine for the count down
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            powerupIndicator.gameObject.SetActive(true);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    // Once the Powerup has been picked up this starts and it waits for 7 seconds then the powerup will be gone
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    // This function is called upon when there is a collision
    // Resets the boolean onGround to true if the player has it the ground
    // And displays 'Game Over!' when the player collides with Bullet-Bill
    // There are no return values   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}