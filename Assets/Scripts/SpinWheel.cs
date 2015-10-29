using UnityEngine;
using System.Collections;

public class SpinWheel : MonoBehaviour
{
    public float minSwipeDistY;
    public float minSwipeDistX;
    private Vector2 startPos;
    public float power = 100; //the engine power applied to the wheel
    public float velocity = 0.1f;
    RaycastHit hit;
    public GameObject wheel; //the object whose velocity you are calculating

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
                    //Input.GetTouch(0).position
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
                    // var wheelpower = velocity * power * Time.deltaTime; //velocity of "car" * engine power

                    if (swipeDistHorizontal > minSwipeDistX && Physics.Raycast(ray, out hit) && DragDropTrial.isDragged())
                    { 
                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
                        //GetComponent<SphereCollider>().gameObject.transform.position;

                        if (swipeValue > 0)
                        {
                            transform.Rotate(0, 0, 2);
                        }
                        else if (swipeValue < 0)
                        {
                            transform.Rotate(0, 0, -2);
                        }
                    }
                    break;
            }
        }
       /* if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.point.ToString());
                //transform.Translate(hit.point - transform.position);
            }

        } */
    }
}
