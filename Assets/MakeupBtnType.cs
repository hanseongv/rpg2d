using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MakeupBtnType : MonoBehaviour
{
    public MakeupTypeBtn currentType;

    private GameObject gameManager;
    public List<GameObject> makeupTypeUp;
    public List<GameObject> makeupTypeUpText;
    private GameObject gameobject;
    private List<string> makeupTypeUpName = new List<string>(new string[] { "HairBtnUp", "FaceBtnUp", "SkinBtnUp" });
    private List<string> makeupListName = new List<string>(new string[] { "HairList", "FaceList", "SkinList" });
    public List<Image> image;
    public List<GameObject> gameobjList;

    //public List<Sprite> Hair;
    public UserData userData;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        userData = gameManager.GetComponent<UserData>();
        for (int i = 0; i < 3; i++)
        {
            gameobject = GameObject.Find("UI/Canvas/MakeupTypeUp/" + makeupTypeUpName[i]);
            makeupTypeUp.Add(gameobject);
            gameobject = GameObject.Find("UI/Canvas/MakeupTypeUp/" + makeupTypeUpName[i] + "/Text");
            makeupTypeUpText.Add(gameobject);
            gameobject = GameObject.Find("UI/Canvas/MakeupList/" + makeupListName[i]);
            gameobjList.Add(gameobject);
            gameobjList[i].SetActive(false);
        }
    }

    public void OnBtnClick()
    {
        int i = 0;
        for (i = 0; i < 3; i++)
        {
            makeupTypeUp[i].GetComponent<Image>().enabled = true;
            makeupTypeUpText[i].GetComponent<Text>().enabled = true;
            gameobjList[i].SetActive(false);
        }
        switch (currentType)
        {
            case MakeupTypeBtn.Hair:
                i = 0;
                break;

            case MakeupTypeBtn.Face:
                i = 1;
                break;

            case MakeupTypeBtn.Skin:
                i = 2;
                break;
        }
        makeupTypeUp[i].GetComponent<Image>().enabled = false;
        makeupTypeUpText[i].GetComponent<Text>().enabled = false;
        gameobjList[i].SetActive(true);
    }
}