using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public GameObject target;
    public float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
