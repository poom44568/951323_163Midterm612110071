using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warpdoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider warp)
    {
        if (warp.gameObject.CompareTag("Player"))
        {
            SceneManager.UnloadSceneAsync("Stage1");
            SceneManager.LoadScene("Stage2");
        }
    }
}
