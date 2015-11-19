using UnityEngine;
using System.Collections;

public class EnableOrDisable : MonoBehaviour
{

    public GameObject tela;
    public GameObject[] buttonList;

    public void ButtonDisabler()
    {
        if (tela.activeSelf)
        {
            buttonList[0].SetActive(true);
            buttonList[1].SetActive(true);
            tela.SetActive(false);
        }
        else
        {
            buttonList[0].SetActive(false);
            buttonList[1].SetActive(true);
            tela.SetActive(true);
        }
    }
}

