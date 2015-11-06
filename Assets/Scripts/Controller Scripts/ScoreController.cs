using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {
	public string ScoreTAG,ScoreGameOver, HighScoreTAG;
	private GameObject Score,ScoreGameOverr,HighScorer;
    private int Scorer;
    private int HighScore;
    // Use this for initialization
    void Start () {
		Score = GameObject.FindGameObjectWithTag (ScoreTAG);
		ScoreGameOverr= GameObject.FindGameObjectWithTag (ScoreGameOver);
		HighScorer= GameObject.FindGameObjectWithTag (HighScoreTAG);
        getPlayerPrefs();
    }
	
	// Update is called once per frame
	void Update () {
        Scorer = (int)Time.timeSinceLevelLoad;
        Score.GetComponent<Text>().text = "" + Scorer;
		ScoreGameOverr.GetComponent<Text>().text = "" + Scorer;
		HighScorer.GetComponent<Text>().text = "" + HighScore;
        if (Scorer >= HighScore) {
			HighScore=Scorer;
            setPlayerPrefs(Scorer);
            PlayerPrefs.Save();
        }
    }
   public int GetScore() {
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
}
