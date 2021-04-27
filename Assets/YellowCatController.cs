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

        Vector2 p1 = transform.position; //����� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position; //�÷��̾� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //����̿� �÷��̾� ���� �Ÿ�
        float r1 = 0.6f; //����� �ݰ�
        float r2 = 1.0f;//�÷��̾� �ݰ�

        if (d < r1 + r2) //����̿� �÷��̾ �浹�� ���
        {
            transform.Translate(-1, 0, 0); //����̴� ��������
            this.player.transform.Translate(1, 0, 0); //�÷��̾�� ����������
        }
    }
}
