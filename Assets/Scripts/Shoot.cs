using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    private GameObject target;
    private float distance;
    public float speed = 50f;
    public float DeathTime = 1f;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Respawn");
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector2.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
        distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance <= 0.01)
        {
            Destroy(transform.gameObject);
        }
        // DestroyObject(gameObject, DeathTime);
        //GameObject.Destroy(gameObject, DeathTime);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "enemy(Clone)")
        {
            Destroy(collider.gameObject);
            Destroy(transform.gameObject);
        }
        if (collider.gameObject.name == "bullet(Clone)")
        {
            Destroy(collider.gameObject);
            Destroy(transform.gameObject);
        }
        if(collider.gameObject.name == "ostra1(Clone)")
        {
            Destroy(collider.gameObject);
            Destroy(transform.gameObject);
        }
    }
}
