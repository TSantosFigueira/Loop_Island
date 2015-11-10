using UnityEngine;
using System.Collections;

public class ShootPrototype : MonoBehaviour {
    public GameObject bullet;
    private GameObject target;
    private float distance;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Respawn");
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.parent.gameObject.transform.position, target.transform.position, 10f);
        distance = Vector3.Distance(transform.parent.gameObject.transform.position, hit.collider.gameObject.transform.position);
        if (transform.parent.gameObject.tag == "diskDock" && hit && hit.collider && distance == 5f)
        {
            GameObject projectile = Instantiate(bullet) as GameObject;
            bullet.transform.position = transform.parent.gameObject.transform.position + Camera.main.transform.position * 2;
            Debug.Log("O Colisor é: " + hit.collider);
        }
    }
}
