using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 10;//ジャンプ力
    [SerializeField] float gravityModifier;//重力値調整用
    [SerializeField] bool isOnGround = true;//地面についているか
    Rigidbody playerRb;//privateは省略可能
    public bool gameOver = false;//何も書かなければprivateになる
    Animator playerAnim;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver){//スペースキーを押され、かつ、地面にいたら
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);//上に力を加える
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");//ジャンプアニメ発動準備
        }
    }
    void OnCollisionEnter(Collision collision)//硬い物と衝突した場合に反応させる
    {
        if (collision.gameObject.CompareTag("Ground")){
            isOnGround = true;//地面についている状態に変更
        }
        if (collision.gameObject.CompareTag("Obstacle")){
            gameOver = true;//ゲームオーバーにする
            playerAnim.SetBool("Death_b", true);//ここで死亡状態bにする。(Death_bとかいうのは本来自分で定義できる)
            playerAnim.SetInteger("DeathType_int", 1);//integerは整数の意味。死亡タイプ?を1番目のやつにする的な。
        }
    }
}
