using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeControlStage2 : MonoBehaviour
{
    public float timeDefault = 20;
    public bool timeIsRunning = false;
    public Text timetell;
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
                timetell.text = timeDefault.ToString("0.00");
            }
            else
            {
                timeDefault = 0;
                timeIsRunning = false;
                SceneManager.UnloadSceneAsync("Stage2");
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
