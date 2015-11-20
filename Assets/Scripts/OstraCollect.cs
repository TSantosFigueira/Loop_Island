using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OstraCollect : MonoBehaviour {
 
    void OnMouseDown () {
       if (gameObject.name == "ostra1(Clone)")
        {
            ScoreController.SetScore(20);
            Destroy(gameObject);
        }           
	}
}
