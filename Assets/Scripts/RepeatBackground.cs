using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//���s�[�g�J�n�ʒu

    void Start()
    {
        startPos = transform.position;//�Q�[���J�n���̏ꏊ���L��
    }

    void Update()
    {
        if(startPos.x - transform.position.x> 50.0f)//�����������������ꂽ��
        {
            transform.position = startPos;//�ꏊ�����Z�b�g

        }
    }
}
