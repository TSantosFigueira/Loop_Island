using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour {
    [SerializeField] GameObject turret;
    float speed = 5f;

	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, turret.transform.position, speed * Time.deltaTime);
	}
}
