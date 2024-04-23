using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
    public Material[] skyboxMaterials; // 변경할 스카이박스 머티리얼 배열
    private int currentMaterialIndex = 0; // 현재 스카이박스 머티리얼 인덱스

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
        if (skyboxMaterials.Length == 0) return; // 머티리얼 배열이 비어있으면 함수 종료

        // 다음 머티리얼 인덱스로 업데이트, 마지막 인덱스에 도달하면 0으로 초기화
        currentMaterialIndex = (currentMaterialIndex + 1) % skyboxMaterials.Length;
        // 현재 인덱스에 해당하는 스카이박스 머티리얼로 변경
        RenderSettings.skybox = skyboxMaterials[currentMaterialIndex];
        DynamicGI.UpdateEnvironment(); // 변경된 머티리얼을 적용하기 위해 환경 업데이트
    }

}
