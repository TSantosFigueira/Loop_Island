using UnityEngine;
using System.Collections;

public class SpinWheel : MonoBehaviour
{
    public float minSwipeDistY;
    public float minSwipeDistX;
    private Vector2 startPos;
    public float power = 100; //the engine power applied to the wheel
    public float velocity = 0.1f;
    public GameObject wheel; //the object whose velocity you are calculating
    //AudioSource audio;
    //public AudioClip music1;
  //  public AudioClip music2;

    //void Start()
    //{
     //   audio = GetComponent<AudioSource>();
   // }

        void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                case TouchPhase.Moved:
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
                    if (swipeDistHorizontal > minSwipeDistX && Physics.Raycast(ray, out hit))
                    { 
                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
                       
                        if (swipeValue > 0)
                        {
           //                 audio.PlayOneShot(music1, 1f);
                            transform.Rotate(0, 0, 2);
                        }
                        else if (swipeValue < 0)
                        {
             //               audio.PlayOneShot(music2, 1f);
                            transform.Rotate(0, 0, -2);
                        }
                    }
                    break;
            }
        }
    }
}
