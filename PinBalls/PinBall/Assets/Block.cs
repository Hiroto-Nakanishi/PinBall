using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    GameObject scoreUI;

    public int a;
    

    // Use this for initialization
    void Start()
    {
        scoreUI = GameObject.Find("Score");
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "Ball")
        {
            //スコア処理を追加
            scoreUI.GetComponent<Score>().AddPoint(a);

        }
    }

}