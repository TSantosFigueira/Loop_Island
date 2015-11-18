using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour
{

    public void PlayButton()
    {
        Application.LoadLevel("Mapa");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}