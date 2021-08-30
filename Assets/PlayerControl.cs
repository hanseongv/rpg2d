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

    private CapsuleCollider2D standColl;

    private Transform playerTransform;
    private Transform courrentPlayerTransform;

    private void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        //gameobject = GetComponentInChildren<GameObject>();
        gameobject = transform.GetChild(0).gameObject;
        standColl = GetComponent<CapsuleCollider2D>();

        playerTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
            anim.SetBool("isMove", true);

            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
            anim.SetBool("isMove", true);

            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else anim.SetBool("isMove", false);

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            anim.SetBool("isJump", true);
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, playerJumpPower);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
            anim.SetBool("isJump", false);
    }
}