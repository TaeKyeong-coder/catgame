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
        //0.05f + 0.1f*Random.value�ϸ� 0.1~1������ ���� �������� �����ϰ� �װſ� 0.1�̶�� �⺻�ӵ� ����.
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

        Vector2 p1 = transform.position; //star1 �߽� ��ǥ
        Vector2 p2 = this.player.transform.position; //�÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //star1�� �÷��̾� ���� �Ÿ�
        float r1 = 0.5f; 
        float r2 = 1.0f;

        if (d < r1 + r2) 
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();
            Destroy(gameObject);//�浹�� ���� ȭ���� ����.
        }
    }
}
