using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public List<GameObject> obstacle;
    public TextMeshProUGUI scoreText;
    public Transform obstacle;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        // Finds the scoreManager in the scene instead of managing mulitple managers
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
