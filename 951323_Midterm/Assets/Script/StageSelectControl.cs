using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectControl : MonoBehaviour
{
    [SerializeField] Button _stage1Button;
    [SerializeField] Button _stage2Button;
    [SerializeField] Button _backButton;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });
        _stage1Button.onClick.AddListener(delegate { Stage1ButtonClick(_stage1Button); });
        _stage2Button.onClick.AddListener(delegate { Stage2ButtonClick(_stage2Button); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stage1ButtonClick(Button button)
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Stage2ButtonClick(Button button)
    {
        SceneManager.LoadScene("Stage2");
    }

    public void BackButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("StageSelect");
        SceneManager.LoadScene("MainMenu");
    }
}
