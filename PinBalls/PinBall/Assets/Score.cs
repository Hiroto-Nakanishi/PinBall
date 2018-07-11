using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    // スコアを表示する
    public Text scoreText;

    // スコア
    private int score;

    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        // スコア・ハイスコアを表示する
        scoreText.text = "Score: " +score.ToString();
    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;

    }

    // ポイントの追加
    public void AddPoint(int point)
    {
        score = score + point;
    }

}
