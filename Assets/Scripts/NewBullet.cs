using UnityEngine;
using System.Collections;

public class NewBullet : MonoBehaviour
{
    // Public gameobject where you will drag the prefab you want to spawn.
    public GameObject bullet;
    public float delayTime = 5f;

    void Start()
    {
       StartCoroutine(SpawnBullet());
    }

    /* void Update()
    {
        if (transform.parent.gameObject.tag == "diskDock")
        {
            // Spawn game object whereever the object of the script is located.
            Instantiate(bullet, transform.position, Quaternion.identity);
            // Wait for seconds befor continueing the loop.
            //yield return new WaitForSeconds(delayTime);
        }
    } */

    // Function type that allows us to use wait function.
    IEnumerator SpawnBullet()
      {
          while (true)
          {
             if (transform.parent.gameObject.tag == "diskDock") {
                  // Spawn game object whereever the object of the script is located.
                  Instantiate(bullet, transform.position, Quaternion.identity);
                  // Wait for seconds befor continueing the loop.
             }
            yield return new WaitForSeconds(delayTime);
        }
      }

}
