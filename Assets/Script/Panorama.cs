using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panorama : MonoBehaviour
{
    public Material skybox_Material;
    public Texture2D[] skyboxImages;
    private int currentIndex = 0;
    public Text panoramaImageName;

    // Update is called once per frame

    private void Start()
    {
        UpdateImageName();
    }
    void Update()
    {
        // 오른쪽 화살표 키 입력 시
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex >= skyboxImages.Length)
            {
                currentIndex = 0;
            }
            skybox_Material.SetTexture("_MainTex", skyboxImages[currentIndex]);
            UpdateImageName();
        }
        // 왼쪽 화살표 키 입력 시
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = skyboxImages.Length - 1;
            }
            skybox_Material.SetTexture("_MainTex", skyboxImages[currentIndex]);
            UpdateImageName();
        }
    }

    void UpdateImageName()
    {
        if (panoramaImageName != null)
        {
            panoramaImageName.text = skyboxImages[currentIndex].name;
        }
    }
}