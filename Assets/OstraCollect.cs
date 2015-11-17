using UnityEngine;
using System.Collections;

public class OstraCollect : MonoBehaviour {
    public static int score = 100;

    
    void OnMouseDown () {
        //Golbal Score
        score += 20;
	

    // destroy ostra
    Destroy(gameObject);
	
	}
}
