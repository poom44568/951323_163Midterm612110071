using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuControlBGMSFX : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] Button buttonStageselect;
    [SerializeField] Button buttonOptions;
    [SerializeField] Button buttonCredit;
    [SerializeField] Button buttonExit;

    AudioSource audiosourceButtonUI;
    [SerializeField] AudioClip audioclipHoldOver;
    void Start()
    {
        this.audiosourceButtonUI = this.gameObject.AddComponent<AudioSource>();
        this.audiosourceButtonUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer.FindMatchingGroups("UI")[0];
        SetupButtonsDelegate();
        if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Play();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audiosourceButtonUI.isPlaying)
            audiosourceButtonUI.Stop();

        audiosourceButtonUI.PlayOneShot(audioclipHoldOver);
    }

    void SetupButtonsDelegate()
    {
        buttonStageselect.onClick.AddListener(delegate { StageSelectButtonClick(buttonStageselect); });
        buttonOptions.onClick.AddListener(delegate { OptionsButtonClick(buttonOptions); });
        buttonCredit.onClick.AddListener(delegate { CreditButtonClick(buttonCredit); });
        buttonExit.onClick.AddListener(delegate { ExitButtonClick(buttonExit); });
    }

    public void StageSelectButtonClick(Button button)
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OptionsButtonClick(Button button)
    {
        if (!GameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("Options", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }

    public void CreditButtonClick(Button button)
    {
        SceneManager.LoadScene("Credit");
    }

    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
}
