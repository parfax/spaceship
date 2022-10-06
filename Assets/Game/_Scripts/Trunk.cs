using UnityEngine;
using UnityEngine.UI;

public class Trunk : MonoBehaviour
{
    public GameObject[] items;

    // Start is called before the first frame update
    void Start()
    {
    }

    void GiveMoney(int min, int max)
    {
        items[0].SetActive(true);
        int randomValue = Random.Range(min, max), currentMoney = PlayerPrefs.GetInt("money");
        currentMoney += randomValue;
        PlayerPrefs.SetInt("money", currentMoney);
        items[0].GetComponentInChildren<Text>().text = "+" + randomValue + "$";
    }

    // Update is called once per frame
    void Awake()
    {
        int r = Random.Range(0, 23);
        if (r <= 11)
            GiveMoney(15, 200);
        if (r == 12)
            GiveMoney(400, 4001);

        if (r > 12 && PlayerPrefs.GetString($"skin{r - 12}") == "false")
        {
            PlayerPrefs.SetString($"skin{r - 12}", "true");
            items[r - 12].SetActive(bool.Parse(PlayerPrefs.GetString($"skin{r - 12}")));
        }
        else
        {
            GiveMoney(15, 200);
        }

        // if (r == 13)
        // {
        //     if (PlayerPrefs.GetInt("skinn2")==1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn2") == 0)
        //     {
        //     skin2.SetActive(true);
        //     PlayerPrefs.SetInt("skinn2", 1);
        //     }
        // }
        // if (r == 14)
        // {
        //     if (PlayerPrefs.GetInt("skinn3") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if(PlayerPrefs.GetInt("skinn3") == 0)
        //     {
        //     skin3.SetActive(true);
        //     PlayerPrefs.SetInt("skinn3", 1);
        //     }
        // }
        // if (r == 15)
        // {
        //     if (PlayerPrefs.GetInt("skinn4") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn3") == 0) {
        //         skin4.SetActive(true);
        //     PlayerPrefs.SetInt("skinn4", 1); 
        //     }
        // }
        // if (r == 16)
        // {
        //     if (PlayerPrefs.GetInt("skinn5") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn5") == 0) {
        //         skin5.SetActive(true);
        //     PlayerPrefs.SetInt("skinn5", 1); 
        //     }
        // }
        // if (r == 17)
        // {
        //     if (PlayerPrefs.GetInt("skinn6") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn6") == 0) {
        //         skin6.SetActive(true);
        //     PlayerPrefs.SetInt("skinn6", 1);
        //     }
        // }
        // if (r == 18)
        // {
        //     if (PlayerPrefs.GetInt("skinn7") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn7") == 0) {
        //         skin7.SetActive(true);
        //     PlayerPrefs.SetInt("skinn7", 1);
        //     }
        // }
        // if (r == 19)
        // {
        //     if (PlayerPrefs.GetInt("skinn8") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn8") == 0)
        //     {
        //         skin8.SetActive(true);
        //         PlayerPrefs.SetInt("skinn8", 1);
        //     }
        // }
        // if (r == 20)
        // {
        //     if (PlayerPrefs.GetInt("skinn9") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn9") == 0)
        //     {
        //         skin9.SetActive(true);
        //         PlayerPrefs.SetInt("skinn9", 1);
        //     }
        // }
        // if (r == 21)
        // {
        //     if (PlayerPrefs.GetInt("skinn10") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn10") == 0)
        //     {
        //         skin10.SetActive(true);
        //         PlayerPrefs.SetInt("skinn10", 1);
        //     }
        // }
        // if (r == 22)
        // {
        //     if (PlayerPrefs.GetInt("skinn11") == 1)
        //     {
        //         lowMoney();
        //     }
        //     if (PlayerPrefs.GetInt("skinn11") == 0)
        //     {
        //         skin11.SetActive(true);
        //         PlayerPrefs.SetInt("skinn11", 1);
        //     }
        // }
    }
}