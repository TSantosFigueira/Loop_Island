using UnityEngine;
using System.Collections;

public class OstraSpawnCtrl : MonoBehaviour
{
    // Public gameobject where you will drag the prefab you want to spawn.
    public GameObject spawnOstra;
    public float delayTime = 1f;
    private int EnemyCounter = 0;
    public AudioClip powerups;

    void Start()
    {
        StartCoroutine(OstraSpawnTimer());
    }

    // Function type that allows us to use wait function.
    IEnumerator OstraSpawnTimer()
    {
        while (EnemyCounter < 8)
        {

            // Spawn game object whereever the object of the script is located.
            Instantiate(spawnOstra, GetSpawnPosition(), Quaternion.identity);
            EnemyCounter++;
            // Wait for seconds befor continueing the loop.
            yield return new WaitForSeconds(delayTime);
            GetComponent<AudioSource>().PlayOneShot(powerups, 0.4f);
        }
    }

    private Vector3 GetSpawnPosition()
    {
        GameObject[] partes = GameObject.FindGameObjectsWithTag("diskDock");
        int parteIndex = Random.Range(0, partes.Length);
        return partes[parteIndex].transform.position;
    }
}
