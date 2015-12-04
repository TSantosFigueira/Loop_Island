using UnityEngine;
using System.Collections;

public class ObjectsManager : MonoBehaviour {
    public GameObject[] ObjectsToSpawn;
	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("SelectedObject", 0);
        gameObject.GetComponent<Animator>().SetTrigger("piscando");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
