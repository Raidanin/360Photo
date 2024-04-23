using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PanoramaController : MonoBehaviour
{
    public Material panoramaMaterial;
    public float transitionDuration = 1f;
    public Button nextButton;

    private int currentIndex = 0;
    private float transitionTimer = 0f;
    private bool isTransitioning = false;

    private void Start()
    {
        nextButton.onClick.AddListener(OnNextButtonClicked);
    }

    private void Update()
    {
        if (isTransitioning)
        {
            transitionTimer += Time.deltaTime;

            if (transitionTimer >= transitionDuration)
            {
                transitionTimer = 0f;
                isTransitioning = false;
            }

            float t = Mathf.Clamp01(transitionTimer / transitionDuration);
            panoramaMaterial.SetFloat("_Index", Mathf.Lerp(currentIndex, currentIndex + 1, t));
        }
    }

    private void OnNextButtonClicked()
    {
        if (!isTransitioning)
        {
            currentIndex = (currentIndex + 1) % panoramaMaterial.GetInt("_ArraySize");
            isTransitioning = true;
        }
    }
}