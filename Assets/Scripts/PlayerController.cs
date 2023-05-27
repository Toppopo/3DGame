using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 10;//�W�����v��
    [SerializeField] float gravityModifier;//�d�͒l�����p
    [SerializeField] bool isOnGround = true;//�n�ʂɂ��Ă��邩
    Rigidbody playerRb;//private�͏ȗ��\
    public bool gameOver = false;//���������Ȃ����private�ɂȂ�
    Animator playerAnim;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver){//�X�y�[�X�L�[��������A���A�n�ʂɂ�����
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);//��ɗ͂�������
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");//�W�����v�A�j����������
        }
    }
    void OnCollisionEnter(Collision collision)//�d�����ƏՓ˂����ꍇ�ɔ���������
    {
        if (collision.gameObject.CompareTag("Ground")){
            isOnGround = true;//�n�ʂɂ��Ă����ԂɕύX
        }
        if (collision.gameObject.CompareTag("Obstacle")){
            gameOver = true;//�Q�[���I�[�o�[�ɂ���
            playerAnim.SetBool("Death_b", true);//�����Ŏ��S���b�ɂ���B(Death_b�Ƃ������͖̂{�������Œ�`�ł���)
            playerAnim.SetInteger("DeathType_int", 1);//integer�͐����̈Ӗ��B���S�^�C�v?��1�Ԗڂ̂�ɂ���I�ȁB
        }
    }
}
