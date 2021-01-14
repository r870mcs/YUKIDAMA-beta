using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    Vector3 pos;
    Vector3 playerPos;
    public Text text;
    public Text timerText;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //-----ゴールまでの距離を表示する-----
        playerPos = GameObject.Find("Player").transform.position;
        text.text = ((int)pos.z - (int)playerPos.z).ToString();

        if (pos.z-playerPos.z<0)
        {
            text.text = "0";
        }
        else
        {
            //-----タイマーを表示する-----
            timer += Time.deltaTime;
            timerText.text = timer.ToString("f2");
        }
    }
}
