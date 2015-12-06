using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour
{
    private GameObject turret;
    public float speed = 0.1f;
    private int side;
    private int total = 0;
    private float distance;
    private float startTime;
    private bool podeMover = false;

    public bool canShoot = false;

    private void setCanShoot()
    {
        canShoot = true;
    }

    private bool getCanShoot()
    {
        return canShoot;
    }

    private void setPodeMover()
    {
        podeMover = true;
    }

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
        startTime = Time.time;
        turret = WhichSide(Random.Range(1, 7));
    }

    // Update is called once per frame
    void Update()
    {
        if (podeMover)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / Vector3.Distance(transform.position, turret.transform.position);
            transform.position = Vector2.Lerp(transform.position, turret.transform.position, Time.deltaTime * speed);
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        }
            
        //Checks if this enemy has gone too far and hasn't hit any part of the wheel
        distance = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Wheel").transform.position);
        if (distance >= 2.15)
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