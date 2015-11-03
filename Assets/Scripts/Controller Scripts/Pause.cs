using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    private GameObject Pausando;
    public GameObject Carrinho;
    void Start()
    {
        Pausando = GameObject.FindGameObjectWithTag("Pause");
        Pausando.SetActive(false);

    }
    public void Pausa()
    {
        Time.timeScale = 0;

        Pausando.SetActive(true);
        Carrinho.SetActive(false);
    }
}
