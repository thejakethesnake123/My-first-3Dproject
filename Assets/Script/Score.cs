using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NUnit.Framework;

public class Score : MonoBehaviour
{
  
    public Transform trash;
    public TextMeshProUGUI ScoreText;
    public int score = 0;
    public int maxScore;
    public int newScore;
    

    public GameObject Scoring;
    public GameObject YouText;

    void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score += 1;
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score 0" + GlobalScore.SCORE;
    }

    void Update()
    {
        UpdateScore();
        
        if(score == maxScore)
        {
            Scoring.SetActive(false);
            YouText.SetActive(true);
        }
    }

}
