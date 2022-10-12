using Game.Scripts;
using TMPro;
using UnityEngine;

public class Trunk : MonoBehaviour
{
    public TextMeshProUGUI name;
    public SpriteRenderer preview;

    void GiveMoney(int min, int max)
    {
        int randomValue = Random.Range(min, max),
            currentMoney = PlayerPrefs.GetInt("Balance");

        currentMoney += randomValue;
        PlayerPrefs.SetInt("Balance", currentMoney);
        name.text = "+ $" + randomValue;
    }


    private void Awake()
    {
        var r = Random.Range(0, 23);
        if (r <= 11)
            GiveMoney(15, 200);
        if (r == 12)
            GiveMoney(400, 4001);

        var index = r - 12;
        var skinExisting = PlayerPrefs.HasKey($"skin{index}");

        if (r > 12 && !skinExisting)
        {
            PlayerPrefs.SetString($"skin{index}", "");

            PreservationSystem.LoadSkins();
            var skin = PreservationSystem.GetSkin(index);

            name.text = skin.name;
            preview.sprite = skin.sprite;
        }
        else GiveMoney(15, 200);
    }
}