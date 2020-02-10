using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class crossingCollider : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "crossing")
        {

            navMeshAgent.speed = 2f;
            // col.SetActive(false);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "crossing")
        {

            navMeshAgent.speed = 3.5f;
            // col.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
