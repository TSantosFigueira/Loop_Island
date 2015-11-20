using UnityEngine;
using System.Collections;

public class GameOverCanvas : MonoBehaviour
{
    public GameObject Player, PauseScreen, GameOverMenu;
    public GameObject Sound;

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D cool)
    {
        if (cool.gameObject == Player)
        {

            GameOverMenu.GetComponent<Animator>().SetTrigger("GameOver");
            Destroy(PauseScreen);
            Time.timeScale = 0;
            Destroy(Sound);
        }
    }
}
