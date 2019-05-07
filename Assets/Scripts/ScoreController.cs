using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    /// <summary>スコア</summary>
    public static int Score = 0;
    /// <summary>スコアテキスト</summary>
    private Text scoreText;

    private void Awake()
    {
        scoreText = this.gameObject.GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // スコア初期化
        scoreText.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        AddScore();
    }

    /// <summary>
    /// スコア加算
    /// </summary>
    private void AddScore()
    {
        // 経過時間をスコアとして加算
        scoreText.text = Time.time.ToString("f0");
    }
}
