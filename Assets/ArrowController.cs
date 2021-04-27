using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하
        transform.Translate(0, -0.1f, 0);

        //화면 밖으로 나오면 오브젝트 소멸
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position; //화살 중심 좌표
        Vector2 p2 = this.player.transform.position; //플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //화살과 플레이어 간의 거리
        float r1 = 0.5f; //화살 반경
        float r2 = 1.0f;//플레이어 반경

        if(d<r1+r2) //화살과 플레이어가 충돌한 경우
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);//충돌한 경우는 화살을 지움.
        }
    }
}
