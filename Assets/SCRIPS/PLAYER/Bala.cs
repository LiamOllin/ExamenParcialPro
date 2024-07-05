using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bala : MonoBehaviour
{
  //Es al velocidad de movimiento
    public float velocidadBala;

    void Update()
    {
        //se manda a llamar
        MovBala();
        Destroy(this.gameObject, 5f);
    }

    void MovBala()
    {
        //Es el movimiento de la bala en el eje z
        transform.Translate(0,velocidadBala,0 * Time.deltaTime);
    }
}
