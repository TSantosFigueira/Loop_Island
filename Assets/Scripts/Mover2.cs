using UnityEngine;
using System.Collections;

public class Mover2 : MonoBehaviour {
    public GameObject Controller;
    public int ObjectKey;
    public int Custo;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
            PlayerPrefs.SetInt("SelectedObject", ObjectKey);
            PlayerPrefs.SetInt("Custo", Custo);

    }
}
