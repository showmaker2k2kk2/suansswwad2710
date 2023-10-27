using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Emity : MonoBehaviour,ITakeDame// nhận dame,tan cong, animation ,die,agent
{
   protected NavMeshAgent agent;

    public void TakeDame(int Dame)
    {
        throw new System.NotImplementedException();
    }

    protected virtual void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        
    }

}
