using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTime : MonoBehaviour
{
    public float timeDefault = 5;
    public bool timeIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        timeIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning)
        {
            if (timeDefault > 0)
            {
                timeDefault -= Time.deltaTime;
            }
            else
            {
                timeDefault = 0;
                timeIsRunning = false;
                SceneManager.UnloadSceneAsync("MainMenu");
                SceneManager.LoadScene("Splash");
            }
        }
    }

}
