using UnityEngine;
using System.Collections;

public class OstraSpawn : MonoBehaviour
{
    // Public gameobject where you will drag the prefab you want to spawn.
    public GameObject spawnOstra;
    public float delayTime = 1f;
    private int EnemyCounter = 0;

    void Start()
    {
        StartCoroutine(OstraSpawnTimer());
    }

    // Function type that allows us to use wait function.
    IEnumerator OstraSpawnTimer()
    {
        while (EnemyCounter < 2)
        {
            // Spawn game object whereever the object of the script is located.
            Instantiate(spawnOstra, transform.position, Quaternion.identity);
            EnemyCounter++;
            // Wait for seconds befor continueing the loop.
            yield return new WaitForSeconds(delayTime);
        }
    }
}