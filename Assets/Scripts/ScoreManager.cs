using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{

    public static int score;
   

    void Start()
    {
        score = 0;
    }

    public void UpScore()
    {
        //	if(_player.GetComponent<CheckDie>().isLive)
        score++;
    }
 
    public void SaveScore()
    {
        int HighScore = PlayerPrefs.GetInt("highscore");
        if (score > HighScore)
            PlayerPrefs.SetInt("highscore", score);
    }
}