using UnityEngine;
using System.Collections;

public class Mover2 : MonoBehaviour {
    public GameObject Controller;
    public int ObjectKey;
    public int Custo;

    void OnMouseDown()
    {
            PlayerPrefs.SetInt("SelectedObject", ObjectKey);
            PlayerPrefs.SetInt("Custo", Custo);
    }
}
