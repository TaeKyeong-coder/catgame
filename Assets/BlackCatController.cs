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
        Vector2 p1 = transform.position; //���� ����� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position; //�Ͼ� ����� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; //�����̿� �Ͼ��̿��� ���� �Ÿ�
        //float r1 = 0.8f; //���� ����� �ݰ�
        //float r2 = 1.0f;//�Ͼ� ����� �ݰ�

       // if (d < r1 + r2) //����� ���� �浹�� ���
       // {
      //      Destroy(gameObject);
       // }
    }
}
