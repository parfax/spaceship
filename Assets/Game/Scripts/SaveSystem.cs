using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSystem : MonoBehaviour {
    public Text HighScoreTxt;
    public Text HpTxt;
    public Text MoneyTxt;
    // Use this for initialization
    void Start () {
        if (!PlayerPrefs.HasKey("hp"))
        {
            PlayerPrefs.SetInt("hp", 100);
        }
	}
	
	// Update is called once per frame
	void Update () {
        HighScoreTxt.text = "HI " + PlayerPrefs.GetInt("hscore");
        HpTxt.text = "HP " + PlayerPrefs.GetInt("hp");
        MoneyTxt.text = "$" + PlayerPrefs.GetInt("money");

    }
}
