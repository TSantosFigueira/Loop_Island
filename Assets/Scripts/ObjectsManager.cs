using UnityEngine;
using System.Collections;

public class ObjectsManager : MonoBehaviour {
    public GameObject[] ObjectsToSpawn;
	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("SelectedObject", 0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
