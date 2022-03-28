using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ScoreManagerScript : MonoBehaviour
{
    int score;
    public Text scoreText;
    public Text textScore;

    public void Score(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log(score);
        scoreText.text = score.ToString(); 
    }
}
