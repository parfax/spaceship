using System;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {
    public Text curTxt;
    public Text MoneyTxt;
    public int curRec;
    public int okMoney;
    public int curMoney;
    // Use this for initialization
    void Start () {
		curMoney = PlayerPrefs.GetInt("money");
    }
	
	// Update is called once per frame
	void Update () {
        curRec = int.Parse(curTxt.text);
		// if(curRec > 0 && curRec < 1500)
  //       {
  //           MoneyTxt.text = "+$50";
  //           okMoney = 50;
  //       }

		okMoney = (int) Math.Round(.05f * curRec);
        curMoney += okMoney;
        MoneyTxt.text = "+$"+okMoney;
        PlayerPrefs.SetInt("money", curMoney);
        GetComponent<Money>().enabled = false;
	}
}
