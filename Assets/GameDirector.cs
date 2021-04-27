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
        Vector2 p1 = this.cat.transform.position; //����� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position; //�÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //����̿� �÷��̾� ���� �Ÿ�
        this.distance.GetComponent<Text>().text = "yellow cat����" + d.ToString("F2") + "m";
    }
}
