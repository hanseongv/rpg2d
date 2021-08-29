using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinBtnType : MonoBehaviour
{
    public List<Sprite> Skin;
    public UserData userData;
    private GameObject gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        userData = gameManager.GetComponent<UserData>();
    }

    public void OnBtnClick()
    {
        for (int i = 0; i < 6; i++)
        {
            userData.charactorSkinSprite[i].sprite = Skin[i];
        }
    }
}