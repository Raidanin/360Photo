using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
    public Material[] skyboxMaterials; // ������ ��ī�̹ڽ� ��Ƽ���� �迭
    private int currentMaterialIndex = 0; // ���� ��ī�̹ڽ� ��Ƽ���� �ε���

    #region
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    public void ChangeSkyboxMaterial()
    {
        if (skyboxMaterials.Length == 0) return; // ��Ƽ���� �迭�� ��������� �Լ� ����

        // ���� ��Ƽ���� �ε����� ������Ʈ, ������ �ε����� �����ϸ� 0���� �ʱ�ȭ
        currentMaterialIndex = (currentMaterialIndex + 1) % skyboxMaterials.Length;
        // ���� �ε����� �ش��ϴ� ��ī�̹ڽ� ��Ƽ����� ����
        RenderSettings.skybox = skyboxMaterials[currentMaterialIndex];
        DynamicGI.UpdateEnvironment(); // ����� ��Ƽ������ �����ϱ� ���� ȯ�� ������Ʈ
    }

}
