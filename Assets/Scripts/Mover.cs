using UnityEngine;
using System.Collections;
public class Mover : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector3 target;

    void Start()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        target = transform.position;
    }

    void FixedUpdate()
    {
        target.y = transform.position.y;
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out hit, 1000))
            {
                target = hit.point;
            }
        }
        if (Vector3.Distance(transform.position, target) > 0.1f)
        {
            //transform.LookAt(target);
            //transform.Translate(0, 0, speed / 100);
        }
    }
}