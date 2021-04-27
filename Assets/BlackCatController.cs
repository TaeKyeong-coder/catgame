using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCatController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 p1 = transform.position; //검정 고양이 중심 좌표
        Vector2 p2 = this.player.transform.position; //하얀 고양이 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //깜장이와 하양이와의 간의 거리
        //float r1 = 0.8f; //검정 고양이 반경
        //float r2 = 1.0f;//하양 고양이 반경

       // if (d < r1 + r2) //고양이 둘이 충돌한 경우
       // {
      //      Destroy(gameObject);
       // }
    }
}
