using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//���s�[�g�J�n�ʒu
    private float repeatWidth;//���s�[�g�̕�  

    void Start()
    {
        startPos = transform.position;//�Q�[���J�n���̏ꏊ���L��
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        //�w�i�̃R���C�_�[��x�����̒����̔��������s�[�g���ɂ���
        //�y���Ӂz�����Start���ɏ����Ă���̂ŁA��F�ύX�Ƃ��͂���Ȃ�
        //�����ƌŒ�
    }

    void Update()
    {
        if(startPos.x - transform.position.x> repeatWidth){//�����������������ꂽ��
            transform.position = startPos;//�ꏊ�����Z�b�g

        }
    }
}
