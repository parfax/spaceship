using UnityEngine;
using UnityEngine.UI;

public class record : MonoBehaviour {
    public int highRec;
    public int curRec;
    public Text txtHighRecord;
    public Text txtCurRecord;

    public Text panelHighTxt;
    public Text panelCurTxt;
    
	
	void FixedUpdate () {
        panelHighTxt.text = "HI " + PlayerPrefs.GetInt("Highest Score");
        panelCurTxt.text = "" + curRec;

        highRec = PlayerPrefs.GetInt("Highest Score");
        if (curRec > highRec)
        {
            PlayerPrefs.SetInt("Highest Score", curRec);
        }
        txtHighRecord.text = "HI " + highRec;
        txtCurRecord.text = curRec + "";
    }
}
