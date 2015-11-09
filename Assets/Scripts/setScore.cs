using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setScore : MonoBehaviour {
	private ScoreController pontuacao;
	private Text bestScore;
	private Text scoreDaSessao;
	public GameObject button;

	void Start () {
		button.SetActive(false);
		pontuacao = GameObject.FindGameObjectWithTag ("Score").GetComponent<ScoreController> ();


		bestScore = GameObject.Find("HighestScore").GetComponent<Text>();
		bestScore.text = PlayerPrefs.GetInt("highscore").ToString();

		scoreDaSessao = GameObject.Find("ScoreGameOver").GetComponent<Text>();
		//scoreDaSessao.text = pontuacao._score.ToString();
	}
}
