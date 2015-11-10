using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour
{
    private GameObject turret;
    public float speed = 1f;
    private int side;
    private int total = 0;
    private float distance;

    // This function returns which side the turret game object has to go, considering it randomically
    GameObject WhichSide(int side)
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("dock"))
        {
            total += 1;
            if (total == side)
            {
                return obj;
            }
        }
        return null;
    }

    void Start()
    {
        turret = WhichSide(Random.Range(1, 9));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, turret.transform.position, Time.deltaTime);

        //Checks if this enemy has gone too far and hasn't hit any part of the wheel
        distance = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Wheel").transform.position);
        if (distance >= 1.77)
        {
            Destroy(transform.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "diskDock")
        {
            Destroy(gameObject);
            //Destroy(collider.gameObject);
            Destroy(collider.gameObject.GetComponent<Collider2D>().gameObject);
            //Destroy(collider.gameObject.GetComponent<Rigidbody2D>().gameObject.GetComponent<Collider2D>().gameObject);
        }
    }
}