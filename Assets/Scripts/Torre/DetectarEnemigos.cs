using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarEnemigos : MonoBehaviour
{
    public GameObject genBalas;
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
            //genBalas.GetComponent<GenPlasma>().disparar();
            Debug.Log("Funciono el disparo");
        }
    }
}
