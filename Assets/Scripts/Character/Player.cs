using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Emity
{
    public float speed;
    private float ho;
    private float ve;


    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    protected override void Start()
    {
        base.Start();
    }


    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //LookMouse();
        if (dir != Vector3.zero)
        {
            MoveInput(dir);
        }
    }
    void MoveInput(Vector3 dirMove)
    {
        agent.Move(dirMove * speed * Time.deltaTime);
    }
    //void LookMouse()
    //{
    //    Vector3 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Vector3 dir= mousePos- transform.position;
    //    dir.Normalize();
    //    float angle=Mathf.Atan2(dir.x,dir.y)*Mathf.Rad2Deg;
    //    transform.rotation=Quaternion.Euler(0,0,angle);

    //}
}
