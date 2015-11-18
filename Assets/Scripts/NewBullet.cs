using UnityEngine;
using System.Collections;

public class NewBullet : MonoBehaviour
{
    // Public gameobject where you will drag the prefab you want to spawn.
    public GameObject bullet;
    public float delayTime = 5f;
    private float distance;

    private GameObject target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Respawn");
        StartCoroutine(SpawnBullet());
    }

    // Function type that allows us to use wait function.
    IEnumerator SpawnBullet()
      {
        while (true) {
             RaycastHit2D hit = Physics2D.Raycast(transform.parent.gameObject.transform.position, target.transform.position, 50f);
        
            if (transform.parent.gameObject.tag == "diskDock" && hit && hit.collider)
            {
                // Spawn game object whereever the object of the script is located.  transform.parent.position
                Instantiate(bullet, transform.parent.gameObject.transform.position, Quaternion.identity);
                gameObject.GetComponent<Animator>().SetTrigger("atirando");
            }
            // Wait for seconds befor continueing the loop.
            yield return new WaitForSeconds(delayTime);
        }
      }
}
