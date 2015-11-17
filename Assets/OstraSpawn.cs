using UnityEngine;
using System.Collections;

public class OstraSpawn : MonoBehaviour {
    public GameObject prefab;

	void Start () {
        //Spawn first Ostra in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", 30, 30);
	}
	
	void Update () {
        // Load prefab into the Scene
        // -> transform.position means current position
        // -> Quaternion.identity means default rotation
        Instantiate(prefab,transform.position, Quaternion.identity);

    }
}
