using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KeyInput : MonoBehaviour
{
    NavMeshAgent agent;
    public float speed;



        private void Awake()
    {
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();   
        
    }

    void Update()
    {
        //LookMouse2();
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (dir != Vector3.zero)
        {
            MoveInput(dir);
        }
    }
    private void FixedUpdate()
    {
        //LookMouse();
        
    }
    void MoveInput(Vector3 dirMove)
    {
        agent.Move(dirMove * speed * Time.deltaTime);
    }
    void LookMouse2()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    
         if(Physics.Raycast(ray,out hit))
            {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
           }


    }

}
