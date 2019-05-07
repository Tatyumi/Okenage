using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    /// <summary>画面下部のY座標</summary>
    private readonly int offScreenPositionY = (Screen.height / 2) * -1;

    /// <summary>
    /// オブジェクトが画面外かどうか
    /// </summary>
    /// <param name="objectYposition">オブジェクトのY座標</param>
    protected void CheckOffScreen(float objectYposition)
    {
        // 画面外か判別
        if (objectYposition < offScreenPositionY)
        {
            // オブジェクト破棄
            Destroy(this.gameObject);
        }
    }
}
