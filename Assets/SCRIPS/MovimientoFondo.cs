using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFondo : MonoBehaviour
{
    public float velocidadFondo = 0.5f;

    public Renderer ren;

    void Update()
    {
        //float offset = Time.deltaTime * velocidadFondo;
        ren.material.mainTextureOffset += new Vector2(Time.deltaTime * velocidadFondo, 0);
    }
}
