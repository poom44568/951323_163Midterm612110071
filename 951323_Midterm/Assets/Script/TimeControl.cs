using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public float timeDefault = 30;
    public bool timeIsRunning = false;
    public Text timetext;
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
            if(timeDefault > 0)
            {
                timeDefault -= Time.deltaTime;
                timetext.text = timeDefault.ToString("0.00");
            }
            else
            {
                timeDefault = 0;
                timeIsRunning = false;
                SceneManager.UnloadSceneAsync("Stage1");
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

}
