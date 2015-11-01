using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{

    public int _score;
   

    void Start()
    {
        _score = 0;
    }

    public void UpScore()
    {
        //		if(_player.GetComponent<CheckDie>().isLive)
        _score++;
    }
 
    public void SaveScore()
    {
        int HighScore = PlayerPrefs.GetInt("highscore");
        if (_score > HighScore)
            PlayerPrefs.SetInt("highscore", _score);
    }
}