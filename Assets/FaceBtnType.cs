using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FaceBtnType : MonoBehaviour
{
    public Sprite Face;
    public UserData userData;
    private GameObject gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        userData = gameManager.GetComponent<UserData>();
    }

    public void OnBtnClick()
    {
        userData.charactorFaceSprite.sprite = Face;
    }
}