using UnityEngine;
using System.Collections;

public class Home : MonoBehaviour
{

    public void HomeButton()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Menu");
    }
}
