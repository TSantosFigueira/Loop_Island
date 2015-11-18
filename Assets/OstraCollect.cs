using UnityEngine;
using System.Collections;

public class OstraCollect : MonoBehaviour {
    private int score = 100;
     
    void OnMouseDown () {
        if(gameObject.name == "ostra1(Clone)")
        {
            score += 20;
            Destroy(gameObject);
        }            
	}
}
