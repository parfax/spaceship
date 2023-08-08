using UnityEngine;
using UnityEngine.UI;

public class RecordSynchronizer : MonoBehaviour {

    private int highRec;
    [HideInInspector] public int curRec;

    [SerializeField] private Text txtHighRecord,txtCurRecord, panelHighTxt, panelCurTxt;
    
	
	private void FixedUpdate () {
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
