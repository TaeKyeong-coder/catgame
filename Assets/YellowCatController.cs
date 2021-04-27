using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCatController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(-3, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(3, 0, 0);
        }

        Vector2 p1 = transform.position; //고양이 중심 좌표
        Vector2 p2 = this.player.transform.position; //플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //고양이와 플레이어 간의 거리
        float r1 = 0.6f; //고양이 반경
        float r2 = 1.0f;//플레이어 반경

        if (d < r1 + r2) //고양이와 플레이어가 충돌한 경우
        {
            transform.Translate(-1, 0, 0); //고양이는 왼쪽으로
            this.player.transform.Translate(1, 0, 0); //플레이어는 오른쪽으로
        }
    }
}
