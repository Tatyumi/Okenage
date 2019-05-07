using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KerorinController : EnemyController
{
    /// <summary>移動速度</summary>
    private float moveSpeed = -5.0f;

    // Update is called once per frame
    void Update()
    {
        // 下に移動
        this.transform.Translate(0, moveSpeed, 0);

        // 画面外の場合オブジェクトを破棄
        CheckOffScreen(this.transform.localPosition.y);
    }
}
