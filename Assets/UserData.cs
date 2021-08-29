using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    public GameObject playerObj;

    public List<SpriteRenderer> charactorSkinSprite;
    public SpriteRenderer charactorFaceSprite;
    public List<SpriteRenderer> charactorHairSprite;
    private SpriteRenderer spriteRenderer;

    private List<string> skinName = new List<string>(new string[] { "Lfoot", "Rfoot", "body", "Lhand", "Rhand" });
    private List<string> hairName = new List<string>(new string[] { "HairFront", "HairBack" });

    private void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            playerObj = GameObject.Find("PlayerSkin/" + skinName[i]);
            spriteRenderer = playerObj.GetComponentInChildren<SpriteRenderer>();
            charactorSkinSprite.Add(spriteRenderer);
        }
        playerObj = GameObject.Find("LowerBody/UpperBody/Head/head");
        spriteRenderer = playerObj.GetComponentInChildren<SpriteRenderer>();
        charactorSkinSprite.Add(spriteRenderer);
        for (int i = 0; i < 2; i++)
        {
            playerObj = GameObject.Find("LowerBody/UpperBody/Head/head/" + hairName[i]);
            spriteRenderer = playerObj.GetComponentInChildren<SpriteRenderer>();
            charactorHairSprite.Add(spriteRenderer);
        }
        playerObj = GameObject.Find("LowerBody/UpperBody/Head/head/Face");
        charactorFaceSprite = playerObj.GetComponent<SpriteRenderer>();
        //playerObj = GameObject.Find("PlayerSkin/head/OneHairFront");
        //charactorOneHairSprite = playerObj.GetComponent<SpriteRenderer>();
    }
}