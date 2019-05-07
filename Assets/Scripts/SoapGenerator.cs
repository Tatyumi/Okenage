using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapGenerator : MonoBehaviour
{
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>石鹸プレファブ</summary>
    public GameObject SoupPrefab;
    /// <summary>出現間隔</summary>
    private float span = 3.0f;
    /// <summary>計測時間</summary>
    private float delta = 0.0f;
    /// <summary>石鹸プレファブ生成時のY座標</summary>
    private float soupPositionY;
    /// <summary>石鹸プレファブの生成時最大X座標</summary>
    private int maxSoupPositionX;
    /// <summary>石鹸プレファブの生成時最小X座標</summary>
    private int minSoupPositionX;


    // Start is called before the first frame update
    void Start()
    {

        soupPositionY = Screen.height / 2;

        maxSoupPositionX = Screen.width / 2;
        minSoupPositionX = maxSoupPositionX * -1;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(SoupPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);

            // 石鹸プレファブ生成時のX座標を最大値、最小値の間から取得
            int soupPositionX = Random.Range(minSoupPositionX, maxSoupPositionX);

            // 石鹸プレファブの生成座標
            gameObject.transform.localPosition = new Vector2(soupPositionX, soupPositionY);
        }

    }
}
