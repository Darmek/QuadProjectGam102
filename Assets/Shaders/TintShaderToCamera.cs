using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class TintShaderToCamera : MonoBehaviour {

    public Shader ReplacementShader;

    private void OnEnable()
    {
        if (ReplacementShader != null)
            GetComponent<Camera>().SetReplacementShader(ReplacementShader, "RenderType");
    }

    private void OnDisable()
    {
        GetComponent<Camera>().ResetReplacementShader();
    }

}
