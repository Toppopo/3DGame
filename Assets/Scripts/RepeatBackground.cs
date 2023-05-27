using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//リピート開始位置
    private float repeatWidth;//リピートの幅  

    void Start()
    {
        startPos = transform.position;//ゲーム開始時の場所を記憶
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        //背景のコライダーのx方向の長さの半分をリピート幅にする
        //【注意】これはStart内に書いてあるので、毎F変更とかはされない
        //ずっと固定
    }

    void Update()
    {
        if(startPos.x - transform.position.x> repeatWidth){//何か条件が満たされたら
            transform.position = startPos;//場所をリセット

        }
    }
}
