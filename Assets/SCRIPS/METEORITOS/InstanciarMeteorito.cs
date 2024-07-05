using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarMeteorito : MonoBehaviour
{
    //Se encuentra el transform 
    public Transform[] puntoAparicion;
    //Se toma el game object como referencia
    public GameObject aparicionMeteorito;
    //Variable de tiempo
    public float tiempo;
    //Hace random 
    private int numeroR;

    private void Start()
    {
        //Se inicia la corutina
        StartCoroutine(TiempoAparicion());
    }

    IEnumerator TiempoAparicion()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempo);
            Instantiate(aparicionMeteorito, puntoAparicion[numeroR]);
            numeroR = Random.Range(0,puntoAparicion.Length);

        }
    }

}
