using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 10;//�W�����v��
    [SerializeField] float gravityModifier;//�d�͒l�����p
    [SerializeField] bool isOnGround = true;//�n�ʂɂ��Ă��邩
     Rigidbody playerRb;//private�͏ȗ��\

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)//�X�y�[�X�L�[��������A���A�n�ʂɂ�����
        {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);//��ɗ͂�������
            isOnGround = false;
        }
    }
    void OnCollisionEnter(Collision collision)//�d�����ƏՓ˂����ꍇ�ɔ���������
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;//�n�ʂɂ��Ă����ԂɕύX
        }
    }
}
