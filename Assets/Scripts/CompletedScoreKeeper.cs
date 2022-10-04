using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompletedScoreKeeper : MonoBehaviour
{
    public Text scoreText;

    public GameObject player;

    private int score;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            score = (int)Time.time;

            scoreText.text = "SCORE: " + score;
        }
    }
}
