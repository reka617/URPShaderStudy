using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPhaser : MonoBehaviour
{
    Material _mat;
    float _time = 0f;

    void Awake()
    {
        _mat = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        _time += Time.deltaTime;
        if (_time > 2f)
        {
            _time = 0f;
        }

        _mat.SetFloat("_SplitValue", _time);
    }
}
