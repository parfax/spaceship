using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.UI;

public class LoadSys : MonoBehaviour {
    public GameObject btnLeftPos, btnRightPos, btnAttack1Pos, btnAttack2Pos, plyrHP, secondGun;
    public Sprite[] skins;

    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetInt("toggleVE") == 1)
        {
            Camera.main.GetComponent<PostProcessingBehaviour>().enabled = false;
        }
        Vector2 ll, rr, aa1, aa2;
        ll.x = PlayerPrefs.GetFloat("btnLeftPosX");
        ll.y = PlayerPrefs.GetFloat("btnLeftPosY");
        rr.x = PlayerPrefs.GetFloat("btnRightPosX");
        rr.y = PlayerPrefs.GetFloat("btnRightPosY");
        aa1.x = PlayerPrefs.GetFloat("btnAttack1PosX");
        aa1.y = PlayerPrefs.GetFloat("btnAttack1PosY");
        aa2.x = PlayerPrefs.GetFloat("btnAttack2PosX");
        aa2.y = PlayerPrefs.GetFloat("btnAttack2PosY");
        btnLeftPos.transform.position = ll;
        btnRightPos.transform.position = rr;
        btnAttack1Pos.transform.position = aa1;
        btnAttack2Pos.transform.position = aa2;
        if (PlayerPrefs.GetInt("btnAttack1Hidden") == 1)
            btnAttack1Pos.SetActive(false);
        if (PlayerPrefs.GetInt("btnAttack2Hidden") == 1)
            btnAttack2Pos.SetActive(false);

        plyrHP.GetComponent<SpriteRenderer>().sprite = skins[PlayerPrefs.GetInt("skins")];
        plyrHP.GetComponent<SkyTanker>().hp = PlayerPrefs.GetInt("hp");
        
        if(PlayerPrefs.GetInt("gun") == 1)
        {
            secondGun.SetActive(true);
        }
        else
        {
            secondGun.SetActive(false);
        }
    }
}
