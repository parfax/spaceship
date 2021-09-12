using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hudChange : MonoBehaviour
{
    public int check;
    public Text btn1;
    public Text btn2;
    public Text btn3;
    public Text btn4;
    // Start is called before the first frame update
    void Start()
    {
        check = PlayerPrefs.GetInt("hudColor");
        if (!PlayerPrefs.HasKey("hudColor"))
        {
            check = 1;
            btn1.text = "Red•";
            btn2.text = "Yellow";
            btn3.text = "Retro";
            btn4.text = "Old";
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("hudColor", check);
        if (check == 1)
        {
            btn1.text = "Red•";
            btn2.text = "Yellow";
            btn3.text = "Retro";
            btn4.text = "Old";
        }
        if (check == 2)
        {
            btn1.text = "Red";
            btn2.text = "Yellow•";
            btn3.text = "Retro";
            btn4.text = "Old";
        }
        if (check == 3)
        {
            btn1.text = "Red";
            btn2.text = "Yellow";
            btn3.text = "Retro•";
            btn4.text = "Old";
        }
        if (check == 4)
        {
            btn1.text = "Red";
            btn2.text = "Yellow";
            btn3.text = "Retro";
            btn4.text = "Old•";
        }
    }

    public void FirstHud()
    {
        check = 1;
    }
    public void SecondHud()
    {
        check = 2;
    }
    public void ThirdHud()
    {
        check = 3;
    }
    public void FourtHud()
    {
        check = 4;
    }
}
