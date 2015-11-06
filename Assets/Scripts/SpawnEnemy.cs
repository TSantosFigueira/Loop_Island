using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
    // Public gameobject where you will drag the prefab you want to spawn.
    public GameObject spawnEnemy;
    public float delayTime = 5f;
    private int EnemyCounter = 0;

    void Start()
    {
        StartCoroutine(EnemySpawnTimer());
    }

    // Function type that allows us to use wait function.
    IEnumerator EnemySpawnTimer()
    {
        while (EnemyCounter < 5)
        {
            // Spawn game object whereever the object of the script is located.
            Instantiate(spawnEnemy, transform.position, Quaternion.identity);
            EnemyCounter++;
            // Wait for seconds befor continueing the loop.
            yield return new WaitForSeconds(delayTime);
        }
    }
}
