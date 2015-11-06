using UnityEngine;
using System.Collections;

public class Despause : MonoBehaviour
{
    public GameObject Pausando;
    public GameObject EnemySpawner;

    public void Despausa()
    {
        Pausando.SetActive(false);
        EnemySpawner.SetActive(true);
        Time.timeScale = 1;
    }
}