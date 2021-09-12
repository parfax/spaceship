using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreShop : MonoBehaviour {
    public GameObject more,btn1,btn2;
	// Use this for initialization
	void Update () {
        if (PlayerPrefs.GetInt("gun") == 1)
        {
            btn2.SetActive(true);
            btn1.SetActive(false);
        }
        else
        {
            btn1.SetActive(true);
            btn2.SetActive(false);
        }
    }
    public void buySecondGun()
    {
        if (PlayerPrefs.GetInt("monei") >= 8000 && PlayerPrefs.GetInt("gun") == 0)
        {
            int moneyy = PlayerPrefs.GetInt("monei");
            PlayerPrefs.SetInt("gun", 1);
            moneyy -= 8000;
            PlayerPrefs.SetInt("monei", moneyy);
        }
    }
    public void buyPlusHP()
    {
        if (PlayerPrefs.GetInt("monei") >= 500)
        {
            int hpPower = PlayerPrefs.GetInt("hp");
            int moneyy = PlayerPrefs.GetInt("monei");
            hpPower += 5;
            PlayerPrefs.SetInt("hp", hpPower);
            moneyy -= 500;
            PlayerPrefs.SetInt("monei", moneyy);
        }
    }
    public void moree()
    {
        more.SetActive(true);
        gameObject.SetActive(false);
    }
    public void Backk()
    {
        gameObject.SetActive(false);
    }
}
