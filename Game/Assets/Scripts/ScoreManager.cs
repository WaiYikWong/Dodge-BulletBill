using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    public float scoreCount;
    public static float hiScoreCount;
    public float pointsPerSecond;
    public bool scoreIncreasing;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Score increase by one every other second
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        
        // High score will be updated to the current score when the scoreCount is higher than the hiScoreCount
        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
        }

        // Will add the numbers next to the text and will be rounded.
        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount);
    }
}
