using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� ī�޶� �Ѿư���
public class Forever_ChaseCamera : MonoBehaviour
{

    void LateUpdate()// ��� �����Ѵ�(���� ���� ó���� ��������)
    {
        Vector3 pos = this.transform.position; // �ڽ��� ��ġ
        pos.z = -10; // ī�޶��̹Ƿ� ������ �̵���Ų�� 
        Camera.main.gameObject.transform.position = pos;
    }
}
