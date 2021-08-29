using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HairBtnType : MonoBehaviour
{
    public HairTypeBrn currentType;
    public List<Sprite> Hair;
    public UserData userData;
    private GameObject gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        userData = gameManager.GetComponent<UserData>();
    }

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case HairTypeBrn.twoHair:
                Debug.Log("여자머리");

                for (int i = 0; i < 2; i++)
                {
                    userData.charactorHairSprite[i].sprite = Hair[i];
                }
                break;

            case HairTypeBrn.oneHair:
                Debug.Log("미구현");
                userData.charactorHairSprite[0].sprite = Hair[0];
                userData.charactorHairSprite[1].sprite = null;
                break;
        }
    }
}