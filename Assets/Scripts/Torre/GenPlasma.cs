using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenPlasma : MonoBehaviour
{
    public GameObject balaObject;
    public bool flagBala = true;
    int cont=0;
    public int rateBala = 100;
    int contBala = 0;

    // Start is called before the first frame update
    void Start()
    {
        flagBala = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButton(0) && flagBala==false)
        {
            disparar();
        }

        if (flagBala && cont < rateBala)
        {
            cont++;
        }
        else {
            flagBala = false;
            cont = 0;
        }*/
        if (flagBala == false && contBala < rateBala)
        {
            contBala++;
        }
        else
        {
            contBala = 0;
            flagBala = true;
        }
    }
    public void disparar()
    {
        if (flagBala)
        {
            GameObject balaPlasma;
            balaPlasma = Instantiate(balaObject, transform.position, transform.rotation);
            contBala = 0;
            flagBala = false;
        }
  
        
    }
}
