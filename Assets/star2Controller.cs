using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star2Controller : MonoBehaviour
{
    int move = 0;
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {

        if(this.move == 0)
        {
            transform.Translate(0, -1, 0);
            if(transform.position.y == -4)
            {
                this.move = 1;
            }
        }
        
        if (this.move ==1)
        {
            transform.Translate(0, 1, 0);
            if(transform.position.y == 4)
            {
                this.move = 0;
            }
        }

        Vector2 p1 = transform.position; //star2 �߽� ��ǥ
        Vector2 p2 = this.player.transform.position; //�÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //star1�� �÷��̾� ���� �Ÿ�
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().FullHp();
        }

    }
}
