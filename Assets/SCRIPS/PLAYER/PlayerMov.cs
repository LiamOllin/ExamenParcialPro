using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    //Velocidad que tendra el jugador
    public float velocidad;

    //Se toma el rb del del player
    private Rigidbody rb;

    void Update ()
    {
        //Se manda a llamar el rb del perosanje
        rb = GetComponent<Rigidbody>();
        //Se llama el metodo
        Movimiento();
    }

    void Movimiento ()
    {
        //Se optiene la direccion hacia donde quieres que se mueva y en las comillas se pone si quieres que se mueva en Horizontal o Verical
        float movimientoEnH = Input.GetAxis("Horizontal");

        //Se calcula hacia donde se movera
        rb.velocity = new Vector2 (movimientoEnH,0) * velocidad * Time.deltaTime;
    }



}
