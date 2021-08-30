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

    private void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
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
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, playerJumpPower);
            //transform.Translate(new Vector3(0, playerJumpPower * Time.deltaTime, 0));
            //rigid2d.AddForce(new Vector2(0, playerJumpPower), ForceMode2D.Impulse);
        }
    }
}