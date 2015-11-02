using UnityEngine;
using System.Collections;

public class GeneratePowerUp : MonoBehaviour
{
    public GameObject gameObj;
    public float primeiroSpawnEm;
    public float tempoEntreSpawn;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", primeiroSpawnEm, tempoEntreSpawn);
    }
    void CreateObstacle()
    {
        Instantiate(gameObj);

    }
}