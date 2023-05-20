using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//リピート開始位置

    void Start()
    {
        startPos = transform.position;//ゲーム開始時の場所を記憶
    }

    void Update()
    {
        if(startPos.x - transform.position.x> 50.0f)//何か条件が満たされたら
        {
            transform.position = startPos;//場所をリセット

        }
    }
}
