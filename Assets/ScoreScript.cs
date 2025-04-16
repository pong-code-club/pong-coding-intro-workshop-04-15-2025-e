using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int CurrentScore;
    public TextMeshProUGUI ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Score Script Start");

        ScoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //CurrentScore = CurrentScore + 1;
        //calling a function
        //AddToScore();
    }

    //declaring a function called AddToScore
    public void AddToScore()
    {
        CurrentScore = CurrentScore + 1;
        ScoreText.text = "Score: " + CurrentScore;
    }
}
