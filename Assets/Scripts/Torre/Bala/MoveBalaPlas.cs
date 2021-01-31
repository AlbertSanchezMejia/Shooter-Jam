using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalaPlas : MonoBehaviour
{
    public float speed=1;
    public float fireRate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed != 0)
        {
           transform.position += transform.forward*(speed*Time.deltaTime);
           Invoke("Destruir", 3.0f);
        }
    }

    void Destruir()
    {
        Destroy(gameObject);
    }
}
