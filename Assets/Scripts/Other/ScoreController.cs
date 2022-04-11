using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = gameObject.tag + "-" + score;
    }
    [SerializeField] int scoreForGainer;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore()
    {
        score += scoreForGainer;
        scoreText.text = gameObject.tag + "-" + score;
    }
    public void SetScoreForGainer(int score)
    {
        scoreForGainer = score;
    }
    public int GetScoreForGainer()
    {
        return scoreForGainer;
    }
    public int GetActiveScore()
    {
        return score;
    }
}
