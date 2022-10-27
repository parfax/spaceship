using UnityEngine;

public class StoreShop : MonoBehaviour {
    public GameObject more, upgrades, btn1,btn2;


	private void Awake () {
        CheckForSecondGun();
    }



    private void CheckForSecondGun()
    {
        if (PlayerPrefs.GetInt("Gun Type") == 1)
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

    public void Upgrades()
    {
        upgrades.SetActive(true);
        gameObject.SetActive(false);
    }

    public void BuySecondGun()
    {
        if (PlayerPrefs.GetInt("Balance") >= 8000 && PlayerPrefs.GetInt("Gun Type") == 0)
        {
            var balance = PlayerPrefs.GetInt("Balance");
            PlayerPrefs.SetInt("Gun Type", 1);
            balance -= 8000;
            PlayerPrefs.SetInt("Balance", balance);

            CheckForSecondGun();
        }
    }
    public void BuyAdditionalHealthPoints()
    {
        if (PlayerPrefs.GetInt("Balance") >= 500)
        {
            int hpPower = PlayerPrefs.GetInt("Max Health");
            int balance = PlayerPrefs.GetInt("Balance");
            hpPower += 5;
            PlayerPrefs.SetInt("Max Health", hpPower);
            balance -= 500;
            PlayerPrefs.SetInt("Balance", balance);
        }
    }
    public void BuyAdditionalRounds()
    {
        if (PlayerPrefs.GetInt("Balance") >= 500)
        {
            var balance = PlayerPrefs.GetInt("Balance");
            var ammo = PlayerPrefs.GetInt("Ammo");

            PlayerPrefs.SetInt("Ammo", ammo + 200);
            balance -= 500;
            PlayerPrefs.SetInt("Balance", balance);

            CheckForSecondGun();
        }
    }



    public void More()
    {
        more.SetActive(true);
        gameObject.SetActive(false);
    }
    public void Back()
    {
        gameObject.SetActive(false);
    }
    public void BackToShop()
    {
        upgrades.SetActive(false);
    }
}
