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
        if (obstacle && obstacle.position.x <= -10.0f)
        {

            score += 10;
            scoreText.text = ("Points: " + score);
        }
    }
}
