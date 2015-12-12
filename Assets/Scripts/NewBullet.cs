using UnityEngine;
using System.Collections;

public class NewBullet : MonoBehaviour
{
    public GameObject bullet;
    private GameObject target;
    private float delayTime = 5f;
    private float distance;
    public AudioClip atirando;



    void Start()
    {
       target = GameObject.FindGameObjectWithTag("Respawn");
       //StartCoroutine(SpawnBullet());
       InvokeRepeating("CreateBullet", 1, 1);
    }

    void CreateBullet()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.parent.gameObject.transform.position, target.transform.position, 10f);
        if (transform.parent.gameObject.tag == "diskDock" && hit && hit.collider)
        {
            // Instancia o objeto na mesma posição do pai
            Instantiate(bullet, transform.parent.gameObject.transform.position, Quaternion.identity);

            gameObject.GetComponent<Animator>().SetTrigger("atirando");
            GetComponent<AudioSource>().PlayOneShot(atirando, 0.4f);


        }
    }
    
    // Function type that allows us to use wait function.
    IEnumerator SpawnBullet()
    {
        while (true)
        {
           // RaycastHit2D hit = Physics2D.Raycast(transform.parent.gameObject.transform.position, target.transform.position, 50f);

            if (transform.parent.gameObject.tag == "diskDock")// && hit && hit.collider)
            {
                // Instancia o objeto na mesma posição do pai
                Instantiate(bullet, transform.parent.gameObject.transform.position, Quaternion.identity);

                gameObject.GetComponent<Animator>().SetTrigger("atirando");
                GetComponent<AudioSource>().PlayOneShot(atirando, 0.4f);

            }

            yield return new WaitForSeconds(delayTime);
        }
    }
}
