using UnityEngine;
using UnityEngine.PostProcessing;

namespace Game.Scripts
{
    public class PreservationSystem : MonoBehaviour {
        public GameObject btnLeftPos,
            btnRightPos, btnAttack1Pos,
            btnAttack2Pos, plyrHP, secondGun;
        private Sprite[] skins;
        
        private void Start () {
            Camera.main.GetComponent<PostProcessingBehaviour>().enabled = PlayerPrefs.GetInt("PostProcessing") == 0;
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
        
            btnAttack1Pos.SetActive(PlayerPrefs.GetInt("btnAttack1Hidden") == 0);
            btnAttack2Pos.SetActive(PlayerPrefs.GetInt("btnAttack2Hidden") == 0);

            skins = Resources.LoadAll<Sprite>("Skins");
            plyrHP.GetComponent<SpriteRenderer>().sprite = skins[PlayerPrefs.GetInt("skins")];
            plyrHP.GetComponent<SkyTanker>().hp = PlayerPrefs.GetInt("hp");

            secondGun.SetActive(PlayerPrefs.GetInt("gun") == 1);
        }
    }
}
