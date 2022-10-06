using UnityEngine;
using UnityEngine.UI;

public class SaveSystem : MonoBehaviour {
    public Text HighScoreTxt;
    public Text HpTxt;
    public Text MoneyTxt;
    
    void Start () {
        if (!PlayerPrefs.HasKey("Max Health")) PlayerPrefs.SetInt("Max Health", 100);
        if (!PlayerPrefs.HasKey("Highest Score")) PlayerPrefs.SetInt("Highest Score", 0);
        if (!PlayerPrefs.HasKey("Balance")) PlayerPrefs.SetInt("Balance", 539);
        
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
        HighScoreTxt.text = "HI " + PlayerPrefs.GetInt("Highest Score");
        HpTxt.text = "HP " + PlayerPrefs.GetInt("Max Health");
        MoneyTxt.text = "$" + PlayerPrefs.GetInt("Balance");

    }
}
