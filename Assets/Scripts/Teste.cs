using UnityEngine;
using System.Collections;
public class Teste : MonoBehaviour
{
    private float Seno = 0.0f;
    private int vez = 0;
    private float cronometro = 0.0f;
    private float MovimentoEmX;
    private float TorqueEmX;
    private float TorqueEmY;
    private float TorqueEmZ;
    public float VelocidadeVertical = 1f;
    public float DistanciaVertical = 0.8f;
    public float VelocidadeHorizontal = 1.0f;
    public float VelocidadeDeRotacao = 0.4f;
    //public GameObject spawnEnemy;
    void Start()
    {
        MovimentoEmX = Random.Range(-.5f, .5f) * VelocidadeHorizontal;
        TorqueEmX = Random.Range(-5.0f, 5.0f) * VelocidadeDeRotacao;
        TorqueEmY = Random.Range(-5.0f, 5.0f) * VelocidadeDeRotacao;
        TorqueEmZ = Random.Range(-5.0f, 5.0f) * VelocidadeDeRotacao;
        GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(TorqueEmX, TorqueEmY, TorqueEmZ));
    }
    void FixedUpdate()
    {
        if (Seno < Mathf.PI && vez == 0)
        {
            Seno += Time.deltaTime;
        }
        if (Seno >= Mathf.PI)
        {
            vez = 1;
        }
        if (Seno <= 0)
        {
            vez = 0;
        }
        if (Seno >= 0 && vez == 1)
        {
            Seno = 0;
        }
        GetComponent<Rigidbody>().velocity = new Vector3(MovimentoEmX, Mathf.Sin(2 * Seno * VelocidadeVertical) * DistanciaVertical, 0);
        if (cronometro < 10)
        {
            cronometro += Time.deltaTime;
        }
        if (cronometro >= 10)
        {
            cronometro = 0;
            GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(TorqueEmX, TorqueEmY, TorqueEmZ));
        }
    }
}