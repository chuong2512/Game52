using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    public GameObject levelPanel, settingPanel, skinPanel;

    public void Play()
    {
        int unlockLevel = PlayerPrefs.GetInt("UnlockLevel");
        PlayerPrefs.SetInt("CurrentLevel", unlockLevel);
        SceneManager.LoadScene("Level");
    }

    public void ShowLevelSelector()
    {
        AudioManager.instance.buttonAudio.Play();
        levelPanel.SetActive(true);
    }

    public void ShowSetting()
    {
        AudioManager.instance.buttonAudio.Play();
        settingPanel.SetActive(true);
    }

    public void CloseSetting()
    {
        AudioManager.instance.buttonAudio.Play();
        settingPanel.SetActive(false);
    }
    
   
    public void ShowSkin()
    {
        AudioManager.instance.buttonAudio.Play();
        skinPanel.SetActive(true);
    }

    public void CloseSkin()
    {
        AudioManager.instance.buttonAudio.Play();
        skinPanel.SetActive(false);
    }

    public void CloseLevelSelector()
    {
        AudioManager.instance.buttonAudio.Play();
        levelPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
