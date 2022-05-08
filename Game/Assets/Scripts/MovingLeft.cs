using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLeft : MonoBehaviour
{
    private float leftBoundry = -20;
    private float speed = 10;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    //private void Start()
    //{
    //    playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    //    GameObject player = GameObject.FindGameObjectWithTag("Player");
    //    Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
    //}

    // Update is called once per frame
    void Update()
    {
        // constantly moves Bullet-Bill to the left at a constant rate
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        // Destroys Bullet-Bill when it has gone over the boundry limit so that it doesn't lag the game
        if (transform.position.x < leftBoundry && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Ignored")
    //    {
    //        Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
    //    }
    //}
}
