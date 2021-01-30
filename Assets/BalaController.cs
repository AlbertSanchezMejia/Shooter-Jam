using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float speed;
    public float timerB;
    public float shootingDelayB;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Destruirbala();

    }
    void Destruirbala()
    {
        timerB += Time.deltaTime;
        if (timerB >= shootingDelayB)
        {
            Destroy(gameObject);
        }
    }
}