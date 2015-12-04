using UnityEngine;
using System.Collections;

public class CanTouch : MonoBehaviour {
	private bool CanToucher=true;
	public float Timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void CanTouchTrue(){
		this.CanToucher = true;
	}
	public void CanTouchFalse(){
		this.CanToucher = false;
		Invoke ("CanTouchTrue", Timer);
	}
	public bool GetToucher(){
		return this.CanToucher;
	}
}
