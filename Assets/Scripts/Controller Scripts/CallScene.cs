using UnityEngine;
using System.Collections;

public class CallScene : MonoBehaviour
{
    public string Scene;

    void Start()
    {
        Invoke("Splash", 1.6f);
    }
    void Splash()
    {
        Application.LoadLevel(Scene);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
