using UnityEngine;
using System.Collections;

public class MenuPopUp : MonoBehaviour
{

    public void Play()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Menu()
    {
        //Application.LoadLevel ("Menu");
    }
}
