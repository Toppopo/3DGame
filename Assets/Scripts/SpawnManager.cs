using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;//��Q���v���n�u
    private Vector3 spawnPos = new Vector3(25, 0, 0);//�X�|�[������ꏊ
    /* (private float startDelay = 2; private float repeatRate = 2;)[Web��]*/
    float elapsedTime;//�o�ߎ���
    PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
        //�v���C���[����X�N���v�g��D���Ă���(�C���[�W)
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;//��F�̎��Ԃ𑫂��Ă���
        //�o�ߎ��Ԃ�2�b�𒴂��A���A�Q�[���I�[�o�[�ł͂Ȃ�
        if (elapsedTime > 3.0f)
        {
            //!�͔ے�Ȃ̂ŁA!playerControllerScript.gameOver�̈Ӗ��́A�u�Q�[���I�[�o�[�ł͂Ȃ��Ȃ�v�ɂȂ�
            //�������AplayerControllerScript.gameOver == false�Ə����Ă������B
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            elapsedTime = 0.0f;//�o�ߎ��ԃ��Z�b�g
        }
    }
}
