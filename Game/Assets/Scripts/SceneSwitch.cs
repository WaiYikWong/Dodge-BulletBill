using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // This function activates when the Player has collided with a object that has the Obstacle tag which in this case it is Bullet-Bill.
    // What this does is it switches the scene to the death one when you have collided
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }

    // This function activates when the user presses the restart button on scene 1 and will load the main game.
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
}
