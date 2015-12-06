using UnityEngine;
using System.Collections;

public class WinLose : MonoBehaviour {
    public GameObject Lose, Win;
    private GameObject[] turret;

	void Update () {
        turret = GameObject.FindGameObjectsWithTag("diskDock");
        if (turret.Length == 0)
        {
            Time.timeScale = 0;
            Lose.SetActive(true);
        }

        if (SpawnEnemy.EnemyCounter == 15)
        {
            Time.timeScale = 0;
            Win.SetActive(true);
        }
    }
}
