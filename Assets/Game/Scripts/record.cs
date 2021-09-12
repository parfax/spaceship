using UnityEngine;
using UnityEngine.UI;

public class record : MonoBehaviour {
    public int highRec;
    public int curRec;
    public Text txtHighRecord;
    public Text txtCurRecord;

    public Text panelHighTxt;
    public Text panelCurTxt;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        panelHighTxt.text = "HI " + PlayerPrefs.GetInt("hscore");
        panelCurTxt.text = "" + curRec;

        highRec = PlayerPrefs.GetInt("hscore");
        if (curRec > highRec)
        {
            PlayerPrefs.SetInt("hscore", curRec);
        }
        txtHighRecord.text = "HI " + highRec;
        txtCurRecord.text = curRec + "";
    }
}
