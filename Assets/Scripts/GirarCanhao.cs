using UnityEngine;
using System.Collections;

public class GirarCanhao : MonoBehaviour {
    Vector2 foward;
	// Use this for initialization
	void Start () {
        foward = transform.parent.forward;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.parent.gameObject.tag == "diskDock")
        {
            transform.Rotate(foward);
        }            
	}
}
