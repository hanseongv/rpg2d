using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float move;
    public float playerSpeed = 3;
    public float playerJumpPower = 1;
    private Rigidbody2D rigid2d;
    private Animator anim;
    private GameObject gameobject;

    private void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        //gameobject = GetComponentInChildren<GameObject>();
        gameobject = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
            anim.SetBool("isMove", true);
            gameobject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
            anim.SetBool("isMove", true);
            gameobject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else anim.SetBool("isMove", false);

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, playerJumpPower);
            //transform.Translate(new Vector3(0, playerJumpPower * Time.deltaTime, 0));
            //rigid2d.AddForce(new Vector2(0, playerJumpPower), ForceMode2D.Impulse);
        }
    }
}