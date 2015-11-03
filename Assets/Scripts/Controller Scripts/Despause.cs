using UnityEngine;
using System.Collections;

public class Despause : MonoBehaviour
{
    public GameObject Pausando;
    public GameObject Carrinho;

    public void Dispausa()
    {
        Pausando.SetActive(false);
        Carrinho.SetActive(true);
        Time.timeScale = 1;
    }
}