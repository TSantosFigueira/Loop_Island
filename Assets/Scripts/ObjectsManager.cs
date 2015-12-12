using UnityEngine;
using System.Collections;

public class ObjectsManager : MonoBehaviour {
    public GameObject[] ObjectsToSpawn;
    private GameObject CarregandoToLoad;
    public GameObject PiscandoToLoad;
    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("SelectedObject", 0);
        gameObject.GetComponent<Animator>().SetTrigger("piscando");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void SetCarregandoToLoad(GameObject carregando)
    {
        CarregandoToLoad = carregando;
    }
    public GameObject GetCarregandoToLoad()
    {
        return CarregandoToLoad;
    }

    
    public void SetPiscandoToLoad(GameObject piscando)
    {
        PiscandoToLoad = piscando;
    }
    public GameObject GetPiscandoToLoad()
    {
        return PiscandoToLoad;
    }
}
