using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationController : MonoBehaviour
{
    public float sensitivity = 100f; // 회전 감도
    public Transform cameraTransform;

    private float yaw = 0f; // 가로 회전 값
    private float pitch = 0f; // 세로 회전 값

    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) // 마우스 왼쪽 버튼이 눌렸을 때
        {
            
            // 마우스 움직임에 따라 회전 값을 계산
            yaw += sensitivity * Input.GetAxis("Mouse X") * Time.deltaTime;
            pitch -= sensitivity * Input.GetAxis("Mouse Y") * Time.deltaTime;
            pitch = Mathf.Clamp(pitch, -89f, 89f); // 세로 회전이 천장과 바닥에서 막히도록 제한

            // 카메라의 Transform 회전을 갱신
            cameraTransform.eulerAngles = new Vector3(-pitch, -yaw, 0f); // 입력 반대 방향(당기는 방향)으로 회전하도록 회전율 * -1;
        }    
    }
}
