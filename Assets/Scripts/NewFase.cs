using UnityEngine;
using System.Collections;

public class NewFase : MonoBehaviour {

    public string newFase;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void NextButton () {

            Application.LoadLevel(newFase);
        }

    }
