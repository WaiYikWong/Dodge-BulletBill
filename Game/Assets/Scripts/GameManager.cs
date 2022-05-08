using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public List<GameObject> obstacle;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Transform obstacle;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Points: " + score);
        if (transform.position.x > obstacle.position.x)
        {
            score++;
        }

        //scoreText.text = ("Points: " + score);
        //if (obstacle.position.x < -10)
        //{
        //    score++;
        //}
    }
}
