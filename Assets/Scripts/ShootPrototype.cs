using UnityEngine;
using System.Collections;

public class ShootPrototype : MonoBehaviour {
    public GameObject bullet;
    private GameObject target;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Respawn");
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.parent.gameObject.transform.position, target.transform.position, 10f);

        if (transform.parent.gameObject.tag == "diskDock" && hit && hit.collider)
        {
            GameObject projectile = Instantiate(bullet) as GameObject;
            bullet.transform.position = transform.parent.gameObject.transform.position + Camera.main.transform.position * 2;
            Debug.Log("O Colisor é: " + hit.collider);
        }
    }
}
