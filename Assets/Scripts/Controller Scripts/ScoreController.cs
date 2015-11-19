using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int score = 100;
    private int HighScore;
    private GameObject Score, ScoreGameOverr, HighScorer;
    private static int Scorer;

    // Use this for initialization
    void Start()
    {
        Scorer = 0;
        Score = GameObject.FindGameObjectWithTag("Score");
        ScoreGameOverr = GameObject.FindGameObjectWithTag("ScoreGameOver");
        HighScorer = GameObject.FindGameObjectWithTag("HighestScore");
        getPlayerPrefs();
        print(Scorer);
    }

    // Update is called once per frame
    void Update()
    {
        Score.GetComponent<Text>().text = Scorer.ToString();
        ScoreGameOverr.GetComponent<Text>().text = "" + Scorer;
        HighScorer.GetComponent<Text>().text = "" + HighScore;

        if (Scorer >= HighScore)
        {
            HighScore = Scorer;
            setPlayerPrefs(Scorer);
            PlayerPrefs.Save();
        }
    }

    public int GetScore()
    {
        return Scorer;
    }

    void getPlayerPrefs()
    {
        HighScore = PlayerPrefs.GetInt("highscore");
    }

    void setPlayerPrefs(int score)
    {
        PlayerPrefs.SetInt("highscore", score);
    }

    public static void SetScore(int value) // Method to set score every time the player hits an oyster
    {
        Scorer += value;
    }
}
