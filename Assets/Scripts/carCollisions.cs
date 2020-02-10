using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCollisions : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    float speed = 3.5f;
   
   /*
    * Create three colliders on the car, on for the body and front, one for the back and the other for the nagative collider
    * allowing the car to swap colliders and enable the car behind to move along as well
    * Follow how the traffic lights were done, this is similar and can also work in a similar way
    * Fix car movement, make the turning a bit more natural. Maybe use a roundabout or a route that allows for the cars
    * turn more realisticly
    */



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Car")
        {

            navMeshAgent.speed =  -0.5f;
            StartCoroutine(speedTime());
           // col.SetActive(false);
            
        }
    }

    IEnumerator speedTime()
    {
      //  col1.SetActive(true);
        yield return new WaitForSeconds(3);

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {

            navMeshAgent.speed = speed = 3.5f;
            //  StartCoroutine("Speedup");
        }

        }
    }


