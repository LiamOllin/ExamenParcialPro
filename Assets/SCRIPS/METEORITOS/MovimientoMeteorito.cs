using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MovimientoMeteorito : MonoBehaviour
{
    //Es al velocidad de movimiento
    public float velocidadMeteorito;

    void Update()
    {
        //se manda a llamar
        MovMeteorito();
    }

    void MovMeteorito()
    {
        //Es el movimiento del meteorito en el eje z
        transform.Translate(0,0, velocidadMeteorito * Time.deltaTime);
    }

}
