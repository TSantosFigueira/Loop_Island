using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mover2 : MonoBehaviour {
    public GameObject Controller;
    public int ObjectKey;
    public int Custo;
    public GameObject CustoText;
    public int numCannon;
    public GameObject Carregando, Piscando;

    private GameObject piscando;
    void Start()
    {
        CustoText.GetComponent<Text>().text = Custo.ToString();
    }

    void OnMouseDown()
    {

        Controller.GetComponent<ObjectsManager>().SetCarregandoToLoad(Carregando);
        piscando = GameObject.Find("Controller").GetComponent<ObjectsManager>().GetPiscandoToLoad();
        if (piscando)
            piscando.SetActive(false);

        Controller.GetComponent<ObjectsManager>().SetPiscandoToLoad(Piscando);


        piscando = GameObject.Find("Controller").GetComponent<ObjectsManager>().GetPiscandoToLoad();
        piscando.SetActive(true);
        PlayerPrefs.SetInt("SelectedObject", ObjectKey);
        PlayerPrefs.SetInt("Custo", Custo);
    }
}
