using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject cat;
    GameObject player;
    GameObject distance;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.cat = GameObject.Find("cat");
        this.player = GameObject.Find("player");
        this.distance = GameObject.Find("Distance");
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }

    public void FullHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount = (1 / (this.hpGauge.GetComponent<Image>().fillAmount)) * 100;
    }

    void Update()
    {
        Vector2 p1 = this.cat.transform.position; //고양이 중심 좌표
        Vector2 p2 = this.player.transform.position; //플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //고양이와 플레이어 간의 거리
        this.distance.GetComponent<Text>().text = "yellow cat까지" + d.ToString("F2") + "m";
    }
}
