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
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);

        if (hit)
        {
            Debug.Log(hit.collider);
        }

        //Debug.DrawRay(transform.position, transform.LookAt(target.transform.position), Color.green);

        //transform.position = Vector2.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "bowser(Clone)")
        {
            Destroy(collider.gameObject);
            Destroy(transform.gameObject);
        }
    }
}
