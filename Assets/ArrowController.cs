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
        //�����Ӹ��� ������� ����
        transform.Translate(0, -0.1f, 0);

        //ȭ�� ������ ������ ������Ʈ �Ҹ�
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position; //ȭ�� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position; //�÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //ȭ��� �÷��̾� ���� �Ÿ�
        float r1 = 0.5f; //ȭ�� �ݰ�
        float r2 = 1.0f;//�÷��̾� �ݰ�

        if(d<r1+r2) //ȭ��� �÷��̾ �浹�� ���
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);//�浹�� ���� ȭ���� ����.
        }
    }
}