using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour
{
    private GameObject turret;
    public float speed = 1f;
    private int side;
    private int total = 0;

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
        transform.position = Vector2.Lerp(transform.position, turret.transform.position, speed * Time.deltaTime);
    }
}