using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;//��Q���v���n�u
    private Vector3 spawnPos = new Vector3(25, 0, 0);//�X�|�[������ꏊ
    /* (private float startDelay = 2; private float repeatRate = 2;)[Web��]*/
    float elapsedTime;//�o�ߎ���

    /*void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }[Web��]*/

    void Update()
    {
        elapsedTime += Time.deltaTime;//��F�̎��Ԃ𑫂��Ă���
        if (elapsedTime > 2.0f)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            elapsedTime = 0.0f;
        }
    }
    /*void SpawnObstacle()
    {
        
    }*/
}
