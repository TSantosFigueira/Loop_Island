using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int score = 100;
    private GameObject Score;
    private static int Scorer;

    // Use this for initialization
    void Start()
    {
        Scorer = 0;
        Score = GameObject.FindGameObjectWithTag("Score");
        print(Scorer);
    }

    // Update is called once per frame
    void Update()
    {
        Score.GetComponent<Text>().text = Scorer.ToString();
    }

    public int GetScore()
    {
        return Scorer;
    }


    public static void SetScore(int value) // Method to set score every time the player hits an oyster
    {
        Scorer += value;
    }
}
