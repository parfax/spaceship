using UnityEngine;
using UnityEngine.UI;

public class Trunk : MonoBehaviour
{
    public GameObject[] items; // Навіщо? Чому просто не змінювати sprite?

    

    void GiveMoney(int min, int max)
    {
        items[0].SetActive(true);
        int randomValue = Random.Range(min, max), currentMoney = PlayerPrefs.GetInt("Balance");
        currentMoney += randomValue;
        PlayerPrefs.SetInt("Balance", currentMoney);
        items[0].GetComponentInChildren<Text>().text = "+ $" + randomValue;
    }

    // Update is called once per frame
    private void Awake()
    {
        var r = Random.Range(0, 23);
        if (r <= 11)
            GiveMoney(15, 200);
        if (r == 12)
            GiveMoney(400, 4001);

        var index = r - 12;
        print(r + ", " + index);
        var skinExisting = PlayerPrefs.HasKey($"skin{index}");
        if (r > 12 && !skinExisting)
        {
            PlayerPrefs.SetString($"skin{index}", "");
            items[index].SetActive(true); // Фигня, передєлать.
        }
        else GiveMoney(15, 200);
    }
}