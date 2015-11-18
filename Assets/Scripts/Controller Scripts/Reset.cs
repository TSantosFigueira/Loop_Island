using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour
{
    // Use this for initialization

    public void PlayAgain()
    {
        Time.timeScale = 1;
        Application.LoadLevel(Application.loadedLevel);
    }
}
