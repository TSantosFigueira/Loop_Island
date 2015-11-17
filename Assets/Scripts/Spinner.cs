using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {
    private float baseAngle = 0.0f;
    public AudioClip  musica1;
    

 
    void OnMouseDown() //Quando o jogador toca pela primeira vez
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        pos = Input.mousePosition - pos;
        //Mathf.Atan2 retorna o ângulo em radianos cuja tangente é definida por y/x
        baseAngle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        baseAngle -= Mathf.Atan2(transform.right.y, transform.right.x) * Mathf.Rad2Deg;
    }

    void OnMouseDrag() //Quando o jogador arrasta
    {
        
            Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
            pos = Input.mousePosition - pos;
            float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
            transform.rotation = Quaternion.AngleAxis(ang, Vector3.forward);
            GetComponent<AudioSource>().PlayOneShot(musica1, 0.7f);
    
 
        
    }
}
