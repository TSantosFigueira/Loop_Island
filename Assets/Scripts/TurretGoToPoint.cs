using UnityEngine;
using System.Collections;

public class TurretGoToPoint : MonoBehaviour {
    float speed = 5f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    bool lookForCollider(string tag)
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("dock"))
        {
            if (obj.gameObject.tag == tag) return true;
        }

        return false;
    }

    void OnColisionEnter2D (Collision2D collider)
    {
        if(lookForCollider(collider.gameObject.tag)) 
        {
            transform.position = Vector2.MoveTowards(collider.gameObject.transform.position, collider.gameObject.transform.position, speed * Time.deltaTime);
        }
        print(lookForCollider(collider.gameObject.tag));
    }
}
