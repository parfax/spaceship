using UnityEngine;
using UnityEngine.SceneManagement;

public class goSkin : MonoBehaviour
{
    public GameObject skin;

    public void gooSkin()
    {
        skin.SetActive(true);
        gameObject.SetActive(false);
    }

    public void goCase()
    {
        int m = PlayerPrefs.GetInt("money");
        if(m >= 539)
        {
            m -= 539;
            PlayerPrefs.SetInt("money", m);
            SceneManager.LoadScene("cases");
        }
    }
}
