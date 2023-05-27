using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float speed = 5;//Ground����������
    PlayerController playerControllerScript;
    float leftBound = -15;//���̌��E�l
    //���́APlayerController�Ƃ����̂��ARigidbody�Ƃ��Ɠ��l�Ɂu�N���X�v�Ȃ̂�
    //�^�Ƃ��Đ錾���ł���B�g�����͂����Ɠ����ŁA
    //<�^��> �ϐ����@�̏���
    //�i��jRigidbody rb;
    //�i��jint score;
    //����public���ɂ������ꍇ�́A
    //�i��jpublic int score;
    //�ȂǂƂ��邪�A�ӂ���public�ɂ��Ȃ��B�Ƃɂ����A<�^��>+�ϐ����̏���


    void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
        // playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
        //�܂��A���ӂ͓��Ő錾���������Ȃ̂ŁA���Ԃ��s��
        //�����ő�����K�v�B
        //PlayerController�������Ă���̂�Player�{�l�B�Ȃ̂ŁA�܂�������(Find)����K�v������
        //���ꂪGameObject.Find�ł��B�������AFind�̈����ɂ́A�u�ꎚ���v�������O������K�v������܂�
        //�Ȃ̂ŁA"Playe"�Ƃ��뎚�ɂȂ�ƃo�O��܂��B
        //GameObject.Find("Player")���v���C���[���g��\���Ǝv���܂��傤�B
        //��������ƁA�����������Ă���PlayerController�ق����ł��ˁB
        //����́AGetComponent<�^��>()�Ƃ������@�Ŏ���Ă���܂��B
        //���ہA�݂Ȃ����roll a ball ������Ƃ��ɁAplayer��Rigidbody������Ă���Ƃ��Ɉ�񂱂�������Ă��܂��B
    }

    void Update()
    {
        //�Q�[���I�[�o�[��ԂłȂ���΁A�o�b�N�O���E���h�𓮂����B
        if (playerControllerScript.gameOver == false){
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        //���̌��E�l(leftBound)�������ɍs���Ă��܂�����...
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) { 
            //��Q���͏����Ă��܂�
            Destroy(gameObject);
        }
;   }
}
