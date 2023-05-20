using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;//障害物プレハブ
    private Vector3 spawnPos = new Vector3(25, 0, 0);//スポーンする場所
    /* (private float startDelay = 2; private float repeatRate = 2;)[Web解答]*/
    float elapsedTime;//経過時間

    /*void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }[Web解答]*/

    void Update()
    {
        elapsedTime += Time.deltaTime;//毎Fの時間を足していく
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
