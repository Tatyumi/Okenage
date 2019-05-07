using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkeController : MonoBehaviour
{
    /// <summary>移動速度</summary>
    private const float MOVE_SPEED = 5.0f;
    /// <summary>移動できるX座標の最大値</summary>
    private float maxMovePositionX;
    /// <summary>移動できるX座標の最小値</summary>
    private float minMovePositionX;
    /// <summary>オケの標準Y座標</summary>
    private float standardPositionY;

    // Start is called before the first frame update
    void Start()
    {
        // オケの移動できる最大、最小X座標を取得
        maxMovePositionX = Screen.width / 2 - this.gameObject.GetComponent<RectTransform>().sizeDelta.y / 2;
        minMovePositionX = maxMovePositionX * -1;

        // オケの標準Y座標を取得
        standardPositionY = Screen.height / 2 * -1 + this.gameObject.GetComponent<RectTransform>().sizeDelta.x + 10;

        // オケの座標を初期化
        this.transform.localPosition = new Vector2(0, standardPositionY);
    }

    // Update is called once per frame
    private void Update()
    {
        // 左の入力判別
        if (Input.GetKey(KeyCode.LeftArrow))
        {   
            // 入力を検知した場合

            // 左に移動する
            this.transform.Translate(-MOVE_SPEED, 0, 0);
        }

        // 右の入力判別
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // 入力を検知した場合

            // 右に移動する
            this.transform.Translate(MOVE_SPEED, 0, 0);
        }

        // オケのX座標が最大値に達しているか判別
        if(this.transform.localPosition.x > maxMovePositionX)
        {
            this.transform.localPosition = new Vector2(maxMovePositionX, standardPositionY);
        }

        // オケのX座標が最大値に達しているか判別
        if (this.transform.localPosition.x < minMovePositionX)
        {
            this.transform.localPosition = new Vector2(minMovePositionX, standardPositionY);
        }

    }
}
