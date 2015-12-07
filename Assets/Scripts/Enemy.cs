using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    private GameObject turret;
    private int side;
    private int total = 0;

    private int life = 1; // Quantidade de vida que cada inimigo tem

    private float distance;
    private float startTime;
    private bool podeMover = false;

    private bool canShoot = false;

    private void setCanShoot()
    {
        canShoot = true;
    }

    private bool getCanShoot()
    {
        return canShoot;
    }

    private void setPodeMover ()
    {
        podeMover = true;
    }

    // Retorna para que lado o inimigo deve se mover, considerando randomicamente
    GameObject WhichSide (int side)
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

    void Start ()
    {
        startTime = Time.time;
        turret = WhichSide(Random.Range(1, 7));
    }

    // Função chamada uma fez a cada frames
    void Update()
    {
        // Aqui o inimigo se movimenta, caso a animação inicial tenha sido concluída
        if (podeMover) 
        {
            transform.position = Vector2.Lerp(transform.position, turret.transform.position, 0.01f);
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        }
            
        // Verifica se o inimigo atingiu a extremidade do disco, caso o tenha feito ele é destruído
        distance = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Wheel").transform.position);
        if (distance >= 2.15)
        {
            Destroy(transform.gameObject);
        }
    }

    // Lida com colisões
    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.gameObject.tag == "diskDock") // Colidiu com o disco: o inimigo e a parte do disco em que houve colisão são destruídos
        {
            Destroy(gameObject);
            Destroy(collider.gameObject.GetComponent<Collider2D>().gameObject);
        }

        if (collider.gameObject.name == "bullet(Clone)") // colidiu com a bala e a animação inicial já foi finalizadass
        {
            life -= 1;  // Subtrai a vida e destroi a bala
            Destroy(collider.gameObject);

            if (life == 0) // Perdeu todas as vidas: morre
            {
                Destroy(transform.gameObject);
            }
        }
    }
}