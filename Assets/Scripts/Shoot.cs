using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    private GameObject target; 
    public float speed = 5f;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Respawn");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector2.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "bowser(Clone)")
        {
            Destroy(collider.gameObject);
            Destroy(transform.gameObject);
        }
        if (collider.gameObject.name == "bala2(Clone)")
        {
            Destroy(collider.gameObject);
            Destroy(transform.gameObject);
        }
    }
}
