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
    public float zRange = 4f;
    public bool onGround = true;
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

        // Keeps the player from falling off the platform
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zRange)
        {
            transform.position = new Vector3(zRange, transform.position.y, transform.position.x);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }
}
