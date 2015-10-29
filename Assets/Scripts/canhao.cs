using UnityEngine;
using System.Collections;

public class canhao : MonoBehaviour {
    public Transform objeto;
    public int a;

	// Use this for initialization
	void Start () {
        a = 0;
	}
    public void Exemple(Transform newParent)
    {

        // sets "newParent"  as the new  of the player  GameObject.
        gameObject.transform.SetParent(newParent);
        //player.transform.SetParent(newParent);

        //Same as above, except this makes  the player keep its local orientation rather its global  orientation.
        gameObject.transform.SetParent(newParent, false);

    }
	// Update is called once per frame
	void Update () {

        a++;
        if (a == 50)
        {
            Exemple(objeto);
        }
	
	}
}
