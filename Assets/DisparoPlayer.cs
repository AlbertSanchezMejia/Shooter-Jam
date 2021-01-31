using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPlayer : MonoBehaviour
{
    public bool isFiring;

    public float timer;
    public static float shootingDelay = 0.20f;

    public BalaController bala;
    public static float bulletSpeed = 40;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1"))
        {
            isFiring = true;
            if (isFiring == true & timer >= shootingDelay)
            {
                timer = 0;
                shotCounter -= Time.deltaTime;
                shotCounter -= timeBetweenShots;
                BalaController newBullet = Instantiate(bala, firePoint.position, firePoint.rotation) as BalaController;
                newBullet.speed = bulletSpeed;
            }
        }
        else isFiring = false;

    }
}