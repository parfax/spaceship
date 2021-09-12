using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlChange : MonoBehaviour
{
    public int check;
    public Text btn1;
    public Text btn2;
    public Text btn3;
    // Start is called before the first frame update
    void Start()
    {
        check = PlayerPrefs.GetInt("controll");
        if (!PlayerPrefs.HasKey("controll")) {
            check = 1;
            btn1.text = "Selected";
            btn2.text = "Select";
            btn3.text = "Select";
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("controll", check);
        if (check == 1)
        {
            btn1.text = "Selected";
            btn2.text = "Select";
            btn3.text = "Select";
        }
        if (check == 2)
        {
            btn1.text = "Select";
            btn2.text = "Selected";
            btn3.text = "Select";
        }
        if (check == 3)
        {
            btn1.text = "Select";
            btn2.text = "Select";
            btn3.text = "Selected";
        }
    }

    public void FirstCntrl()
    {
        check = 1;
    }
    public void SecondCntrl()
    {
        check = 2;
    }
    public void ThirdCntrl()
    {
        check = 3;
    }
}
