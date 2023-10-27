using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Emity
{
    public float speed;
    private float ho;
    private float ve;

    Animator anim;
    Rigidbody rb;
    bool animator;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim= GetComponent<Animator>();
    }
    protected override void Start()
    {
        base.Start();
    }


    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        LookMouse();
        if (dir != Vector3.zero)
        {
            anim.SetBool("Run", true);
            MoveInput(dir);
        }else
        { anim.SetBool("Run", false); }

    }
    void MoveInput(Vector3 dirMove)
    {
        agent.Move(dirMove * speed * Time.deltaTime);
    }
    void LookMouse()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
 

}