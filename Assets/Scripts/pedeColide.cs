using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pedeColide : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pedestrian" )
        {

            navMeshAgent.speed = 0;
            // col.SetActive(false);

        }

        if (other.gameObject.tag == "crossing")
        {

            navMeshAgent.speed = 2f;
            // col.SetActive(false);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        navMeshAgent.speed =3.5f;
    }

}
