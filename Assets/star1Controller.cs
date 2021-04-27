using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star1Controller : MonoBehaviour
{
    float rotSpeed = 2f;
    GameObject player;
    
    void Start()
    {
        this.player = GameObject.Find("player");
        //0.05f + 0.1f*Random.value하면 0.1~1까지의 값을 무작위로 추출하고 그거에 0.1이라는 기본속도 곱함.
    }

    void Update()
    {
        // transform.Translate(0, -0.1f, 0);
        // transform.Rotate(0, 0, this.rotSpeed);
        transform.Translate(0, -0.05f, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position; //star1 중심 좌표
        Vector2 p2 = this.player.transform.position; //플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //star1과 플레이어 간의 거리
        float r1 = 0.5f; 
        float r2 = 1.0f;

        if (d < r1 + r2) 
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();
            Destroy(gameObject);//충돌한 경우는 화살을 지움.
        }
    }
}
