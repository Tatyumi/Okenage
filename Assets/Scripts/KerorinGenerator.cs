using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KerorinGenerator : MonoBehaviour
{
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>ケロリンプレファブ</summary>
    public GameObject KerorinPrefab;
    /// <summary>出現間隔</summary>
    private float span = 5.0f;
    /// <summary>計測時間</summary>
    private float delta = 0.0f;
    /// <summary>ケロリンプレファブ生成時のY座標</summary>
    private float KerorinPositionY;
    /// <summary>ケロリンプレファブの生成時最大X座標</summary>
    private int maxKerorinPositionX;
    /// <summary>ケロリンプレファブの生成時最小X座標</summary>
    private int minKerorinPositionX;


    // Start is called before the first frame update
    void Start()
    {

        KerorinPositionY = Screen.height / 2;

        maxKerorinPositionX = Screen.width / 2;
        minKerorinPositionX = maxKerorinPositionX * -1;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(KerorinPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);

            // ケロリンプレファブ生成時のX座標を最大値、最小値の間から取得
            int soupPositionX = Random.Range(minKerorinPositionX, maxKerorinPositionX);

            // ケロリンプレファブの生成座標
            gameObject.transform.localPosition = new Vector2(soupPositionX, KerorinPositionY);
        }

    }
}
