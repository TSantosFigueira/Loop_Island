using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
    public AudioSource audio;
    public AudioClip music1;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
