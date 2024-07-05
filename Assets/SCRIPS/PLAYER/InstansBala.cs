using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstansBala : MonoBehaviour
{
    //Se toma el prefab
    public GameObject bala;
    //Se toma el transform de donde aparecera
    public Transform aparicionBala;

    void Update ()
    {
        InsBala();
    }

    public void InsBala()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            GameObject balanNueva;

            balanNueva = Instantiate(bala, aparicionBala.position, aparicionBala.rotation);
        }
    }

}
