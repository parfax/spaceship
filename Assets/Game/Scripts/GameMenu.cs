using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {
    public GameObject shop, settings, loadingScreen, panelMode;
    public Slider LoadingSlider;
    AsyncOperation async;
    private void Start()
    {
        if(!PlayerPrefs.HasKey("toggleVE"))
            PlayerPrefs.SetInt("toggleVE", 0);
    }
    public void Mode()
    {
        panelMode.SetActive(true);
    }
    public void ExitMode()
    {
        panelMode.SetActive(false);
    }
    public void GoStart1()
    {
        loadingScreen.SetActive(true);
        //SceneManager.LoadScene("Game");
        StartCoroutine(Loading());
    }
    public void GoShop()
    {
        shop.SetActive(true);
    }
    public void GoSettings()
    {
        settings.SetActive(true);
        StartCoroutine(settings.GetComponent<settingss>().Fade());
    }
    public void GoExit(GameObject exitPanel)
    {
        exitPanel.SetActive(true);
    }
    public void ExitYes()
    {
        Application.Quit();
    }
    public void ExitNo(GameObject exitPanel)
    {
        exitPanel.SetActive(false);
    }
    IEnumerator Loading()
    {
        async = SceneManager.LoadSceneAsync("Game");
        async.allowSceneActivation = false;

        while (!async.isDone)
        {
            LoadingSlider.value = async.progress;
            if(async.progress==0.9f)
            {
                LoadingSlider.value = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
