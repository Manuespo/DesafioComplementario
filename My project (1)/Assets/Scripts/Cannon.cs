using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Invoke("Shoots", 0);
            Invoke("Shoots", 1);

        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Invoke("Shoots", 0);
            Invoke("Shoots", 1);
            Invoke("Shoots", 2);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Invoke("Shoots", 0);
            Invoke("Shoots", 1);
            Invoke("Shoots", 2);
            Invoke("Shoots", 3);
        }
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }
    private void Shoots()
    {
        Instantiate(munition, transform);
    }

    private void ResetShoot()
    {
        canShoot = true;
    }
}
