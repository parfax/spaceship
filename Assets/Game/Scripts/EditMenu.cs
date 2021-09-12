using UnityEngine;
using UnityEngine.SceneManagement;

public class EditMenu : MonoBehaviour
{
    public GameObject btnLeftPos, btnRightPos, btnAttack1Pos, btnAttack2Pos;
    void Start()
    {
        if (!PlayerPrefs.HasKey("btnLeftPosX"))
        {
            PlayerPrefs.SetFloat("btnLeftPosX", -6.873901f);
            PlayerPrefs.SetFloat("btnLeftPosY", -1.4581f);

            PlayerPrefs.SetFloat("btnRightPosX", 6.873901f);
            PlayerPrefs.SetFloat("btnRightPosY", -1.4581f);

            PlayerPrefs.SetFloat("btnAttack1PosX", 6.873901f);
            PlayerPrefs.SetFloat("btnAttack1PosY", -3.332801f);

            PlayerPrefs.SetFloat("btnAttack2PosX", -6.873901f);
            PlayerPrefs.SetFloat("btnAttack2PosY", -3.332801f);

            PlayerPrefs.SetInt("btnAttack1Hidden", 0);
            PlayerPrefs.SetInt("btnAttack2Hidden", 0);
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
        btnAttack1Pos.GetComponent<editButton>().hidden = PlayerPrefs.GetInt("btnAttack1Hidden");
        btnAttack2Pos.GetComponent<editButton>().hidden = PlayerPrefs.GetInt("btnAttack2Hidden");
    }

    // Update is called once per frame
    void Update()
    {
        if (btnAttack1Pos.GetComponent<editButton>().hidden == 1)
        {
            btnAttack1Pos.SetActive(false);
        }
        else
        {
            btnAttack1Pos.SetActive(true);
        }
        if (btnAttack2Pos.GetComponent<editButton>().hidden == 1)
        {
            btnAttack2Pos.SetActive(false);
        }
        else
        {
            btnAttack2Pos.SetActive(true);
        }
    }
    public void Applyy(GameObject panel)
    {
        PlayerPrefs.SetFloat("btnLeftPosX", btnLeftPos.GetComponent<editButton>().p.x);
        PlayerPrefs.SetFloat("btnLeftPosY", btnLeftPos.GetComponent<editButton>().p.y);

        PlayerPrefs.SetFloat("btnRightPosX", btnRightPos.GetComponent<editButton>().p.x);
        PlayerPrefs.SetFloat("btnRightPosY", btnRightPos.GetComponent<editButton>().p.y);
        
        PlayerPrefs.SetFloat("btnAttack1PosX", btnAttack1Pos.GetComponent<editButton>().p.x);
        PlayerPrefs.SetFloat("btnAttack1PosY", btnAttack1Pos.GetComponent<editButton>().p.y);
        
        PlayerPrefs.SetFloat("btnAttack2PosX", btnAttack2Pos.GetComponent<editButton>().p.x);
        PlayerPrefs.SetFloat("btnAttack2PosY", btnAttack2Pos.GetComponent<editButton>().p.y);

        PlayerPrefs.SetInt("btnAttack1Hidden", btnAttack1Pos.GetComponent<editButton>().hidden);
        PlayerPrefs.SetInt("btnAttack2Hidden", btnAttack2Pos.GetComponent<editButton>().hidden);
        panel.SetActive(false);
    }
    public void Presets(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void PresetOne1(GameObject panel)
    {
        Vector2 l, r, a1, a2;
        l.x = -6.873901f;
        l.y = -1.4581f;
        r.x = 6.873901f;
        r.y = -1.4581f;
        a1.x = 6.873901f;
        a1.y = -3.332801f;
        a2.x = -6.873901f;
        a2.y = -3.332801f;
        btnLeftPos.transform.position = l;
        btnRightPos.transform.position = r;
        btnAttack1Pos.transform.position = a1;
        btnAttack2Pos.transform.position = a2;
        btnAttack1Pos.GetComponent<editButton>().hidden = 0;
        btnAttack2Pos.GetComponent<editButton>().hidden = 0;
        panel.SetActive(false);
    }
    public void PresetTwo2(GameObject panel)
    {
        Vector2 l, r, a1, a2;
        l.x = -6.873901f;
        l.y = -1.4581f;
        r.x = -4.707581f;
        r.y = -1.4581f;
        a1.x = 6.873901f;
        a1.y = -1.4581f;
        a2.x = -6.873901f;
        a2.y = -3.332801f;
        btnLeftPos.transform.position = l;
        btnRightPos.transform.position = r;
        btnAttack1Pos.transform.position = a1;
        btnAttack2Pos.transform.position = a2;
        btnAttack1Pos.GetComponent<editButton>().hidden = 0;
        btnAttack2Pos.GetComponent<editButton>().hidden = 1;
        panel.SetActive(false);
    }
    public void PresetThree3(GameObject panel)
    {
        Vector2 l, r, a1,a2;
        l.x = 4.707581f;
        l.y = -1.4581f;
        r.x = 6.873901f;
        r.y = -1.4581f;
        a1.x = 6.873901f;
        a1.y = -3.332801f;
        a2.x = -6.873901f;
        a2.y = -1.4581f;
        btnLeftPos.transform.position = l;
        btnRightPos.transform.position = r;
        btnAttack1Pos.transform.position = a1;
        btnAttack2Pos.transform.position = a2;
        btnAttack1Pos.GetComponent<editButton>().hidden = 1;
        btnAttack2Pos.GetComponent<editButton>().hidden = 0;
        panel.SetActive(false);
    }
    public void turnOnFireButtons()
    {
        btnAttack1Pos.GetComponent<editButton>().hidden = 0;
        btnAttack2Pos.GetComponent<editButton>().hidden = 0;
    }
    public void closePresets(GameObject panel)
    {
        panel.SetActive(false);
    }
    public void Exitt(GameObject panel)
    {
        Application.LoadLevel("Main");
    }
    public void Restore()
    {
        Vector2 l, r, a1, a2;
        l.x = PlayerPrefs.GetFloat("btnLeftPosX");
        l.y = PlayerPrefs.GetFloat("btnLeftPosY");
        r.x = PlayerPrefs.GetFloat("btnRightPosX");
        r.y = PlayerPrefs.GetFloat("btnRightPosY");
        a1.x = PlayerPrefs.GetFloat("btnAttack1PosX");
        a1.y = PlayerPrefs.GetFloat("btnAttack1PosY");
        a2.x = PlayerPrefs.GetFloat("btnAttack2PosX");
        a2.y = PlayerPrefs.GetFloat("btnAttack2PosY");
        btnLeftPos.transform.position = l;
        btnRightPos.transform.position = r;
        btnAttack1Pos.transform.position = a1;
        btnAttack2Pos.transform.position = a2;
        btnAttack1Pos.GetComponent<editButton>().hidden = PlayerPrefs.GetInt("btnAttack1Hidden");
        btnAttack2Pos.GetComponent<editButton>().hidden = PlayerPrefs.GetInt("btnAttack2Hidden");
    }
}
