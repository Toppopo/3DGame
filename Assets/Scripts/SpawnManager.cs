using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;//障害物プレハブ
    private Vector3 spawnPos = new Vector3(25, 0, 0);//スポーンする場所
    /* (private float startDelay = 2; private float repeatRate = 2;)[Web解答]*/
    float elapsedTime;//経過時間
    PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
        //プレイヤーからスクリプトを奪ってくる(イメージ)
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;//毎Fの時間を足していく
        //経過時間が2秒を超え、かつ、ゲームオーバーではない
        if (elapsedTime > 3.0f)
        {
            //!は否定なので、!playerControllerScript.gameOverの意味は、「ゲームオーバーではないなら」になる
            //もちろん、playerControllerScript.gameOver == falseと書いても同じ。
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
            elapsedTime = 0.0f;//経過時間リセット
        }
    }
}
