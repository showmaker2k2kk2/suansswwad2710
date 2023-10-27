using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    Bullet bullet;
    //public GameObject bulett;
    public ParticleSystem bulett;
    public Transform point;
    Rigidbody rb;
    public float speedbul;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        { Shoot(); }
    }
    void  Shoot()
    {
        ParticleSystem bulet = Instantiate(bulett, point.transform.position,transform.rotation);
        Rigidbody rigidbulet = bulet.GetComponent<Rigidbody>();
        rigidbulet.AddForce(transform.forward * speedbul, ForceMode.Impulse);
    }
}
