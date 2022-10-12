using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class settingss : MonoBehaviour {
    public Image bg;
    public Toggle tgVE;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("PostProcessing") == 0)
        {
            tgVE.isOn = true;
        }
        if (PlayerPrefs.GetInt("PostProcessing") == 1)
        {
            tgVE.isOn = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(!tgVE.isOn)
            PlayerPrefs.SetInt("PostProcessing", 1);
        if (tgVE.isOn)
            PlayerPrefs.SetInt("PostProcessing", 0);
    }
    public void Back()
    {
        gameObject.SetActive(false);
    }
    public void goEditControl(GameObject panel)
    {
        panel.SetActive(true);
    }
    public IEnumerator Fade()
    {
        Color temp = bg.color;
        for (int i = 0; i < 16; i++)
        {
                temp.r = i * 0.04f;
                temp.g = i * 0.04f;
                temp.b = i * 0.04f;
                bg.color = temp;
                yield return new WaitForSeconds(.05f);
        }
    }
}
