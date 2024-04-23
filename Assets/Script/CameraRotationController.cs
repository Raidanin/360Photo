using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationController : MonoBehaviour
{
    public float sensitivity = 100f; // ȸ�� ����
    public Transform cameraTransform;

    private float yaw = 0f; // ���� ȸ�� ��
    private float pitch = 0f; // ���� ȸ�� ��

    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) // ���콺 ���� ��ư�� ������ ��
        {
            
            // ���콺 �����ӿ� ���� ȸ�� ���� ���
            yaw += sensitivity * Input.GetAxis("Mouse X") * Time.deltaTime;
            pitch -= sensitivity * Input.GetAxis("Mouse Y") * Time.deltaTime;
            pitch = Mathf.Clamp(pitch, -89f, 89f); // ���� ȸ���� õ��� �ٴڿ��� �������� ����

            // ī�޶��� Transform ȸ���� ����
            cameraTransform.eulerAngles = new Vector3(-pitch, -yaw, 0f); // �Է� �ݴ� ����(���� ����)���� ȸ���ϵ��� ȸ���� * -1;
        }    
    }
}
