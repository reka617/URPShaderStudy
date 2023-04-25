using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class RPController : MonoBehaviour
{
    [SerializeField] UniversalRenderPipelineAsset _normalAsset;
    [SerializeField] UniversalRenderPipelineAsset _overrideAsset;

    [SerializeField] Slider _slider;

    public void OnSliderValueChange()
    {
        _overrideAsset.renderScale = _slider.value * 2;
        QualitySettings.renderPipeline = _overrideAsset;
    }

    public void OnBTNnormal()
    {
        if (GraphicsSettings.defaultRenderPipeline == _normalAsset)
        {
            GraphicsSettings.defaultRenderPipeline = null;
        }
        else
        {
            GraphicsSettings.defaultRenderPipeline = _normalAsset;
        }
    }

    public void OnBTNoverride() 
    {
        if (QualitySettings.renderPipeline == _overrideAsset)
        {
            QualitySettings.renderPipeline = null;
        }
        else
        {
            QualitySettings.renderPipeline = _overrideAsset;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GraphicsSettings.defaultRenderPipeline = _normalAsset;
        _overrideAsset.supportsHDR = false;
        QualitySettings.renderPipeline = _overrideAsset;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
