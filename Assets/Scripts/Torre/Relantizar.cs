using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relantizar : MonoBehaviour
{
    public float relantizar;
    float velEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "enemigo")
        {
            velEnemigo = col.GetComponent<SeguirPlayer>().speed;
            col.GetComponent<SeguirPlayer>().speed = col.GetComponent<SeguirPlayer>().speed * relantizar;
            //genBalas.GetComponent<GenPlasma>().disparar();
            //Debug.Log("Funciono el disparo");
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "enemigo")
        {
            col.GetComponent<SeguirPlayer>().speed = velEnemigo;
        }
    }
}
