using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Scripts
{
    public class MainMenu : MonoBehaviour {
        public GameObject shop, settings, loadingScreen;
        public Slider loadingSlider;
        private AsyncOperation async;
        private void Start()
        {
            Time.timeScale = 1f; // переписатт єто!
            if(!PlayerPrefs.HasKey("PostProcessing"))
                PlayerPrefs.SetInt("PostProcessing", 0);
        }

        public void LetsPlay()
        {
            loadingScreen.SetActive(true);
            StartCoroutine(LoadGame());
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
        private IEnumerator LoadGame()
        {
            async = SceneManager.LoadSceneAsync("Game");
            async.allowSceneActivation = false;

            while (!async.isDone)
            {
                loadingSlider.value = async.progress;
                if(async.progress==.9f)
                {
                    loadingSlider.value = 1f;
                    async.allowSceneActivation = true;
                }
                yield return null;
            }
        }
    }
}
