using UnityEngine;
using System.Collections;

public class Mover2 : MonoBehaviour {
    public GameObject Controller;
    public int ObjectKey;
    public int Custo;
    public int numCannon;

    void Start()
    {
    }

    void OnMouseDown()
    {
        if (numCannon == 1)
        {
            GameObject.Find("piscando1").GetComponent<Animator>().SetBool("blink", true);
            GameObject.Find("piscando2").GetComponent<Animator>().SetBool("blink", false);
            GameObject.Find("piscando3").GetComponent<Animator>().SetBool("blink", false);
            GameObject.Find("piscando4").GetComponent<Animator>().SetBool("blink", false);
        }
        if (numCannon == 2)
        {
            GameObject.Find("piscando2").GetComponent<Animator>().SetBool("blink", true);
            GameObject.Find("piscando1").GetComponent<Animator>().SetBool("blink", false);
            GameObject.Find("piscando3").GetComponent<Animator>().SetBool("blink", false);
            GameObject.Find("piscando4").GetComponent<Animator>().SetBool("blink", false);
        }
        if (numCannon == 3)
        {
            GameObject.Find("piscando3").GetComponent<Animator>().SetBool("blink", true);
            GameObject.Find("piscando1").GetComponent<Animator>().SetBool("blink", false);
            GameObject.Find("piscando2").GetComponent<Animator>().SetBool("blink", false);
            GameObject.Find("piscando4").GetComponent<Animator>().SetBool("blink", false);
        }
        if (numCannon == 4)
        {
            GameObject.Find("piscando4").GetComponent<Animator>().SetBool("blink", true);
            GameObject.Find("piscando1").GetComponent<Animator>().SetBool("blink", false);
            GameObject.Find("piscando2").GetComponent<Animator>().SetBool("blink", false);
            GameObject.Find("piscando3").GetComponent<Animator>().SetBool("blink", false);
        }
        PlayerPrefs.SetInt("SelectedObject", ObjectKey);
        PlayerPrefs.SetInt("Custo", Custo);
    }
}
