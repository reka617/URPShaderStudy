using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DissolveController : MonoBehaviour
{
    Material _mat;
    [SerializeField] Slider _slider;

    void Awake()
    {
        _mat = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        
    }

    public void OnSliderChange()
    {
        _mat.SetFloat("_SplitValue", _slider.value * 1.06f);
    }
}
