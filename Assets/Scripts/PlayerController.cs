using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 10;//ジャンプ力
    [SerializeField] float gravityModifier;//重力値調整用
    [SerializeField] bool isOnGround = true;//地面についているか
     Rigidbody playerRb;//privateは省略可能

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)//スペースキーを押され、かつ、地面にいたら
        {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);//上に力を加える
            isOnGround = false;
        }
    }
    void OnCollisionEnter(Collision collision)//硬い物と衝突した場合に反応させる
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;//地面についている状態に変更
        }
    }
}
