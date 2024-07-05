using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirMeteorito : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteorito"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);   
        }
    }
}
