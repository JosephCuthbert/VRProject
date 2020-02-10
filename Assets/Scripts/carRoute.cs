using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class carRoute : MonoBehaviour
{


    public NavMeshAgent navMeshAgent;

    public Transform[] wayPoints;
    float speed = 3.5f;
    int m_CurrentWaypointIndex;

    TrafficLights trafic;

    void Start()
    {
        navMeshAgent.SetDestination(wayPoints[0].position);
        navMeshAgent.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % wayPoints.Length;

            navMeshAgent.SetDestination(wayPoints[m_CurrentWaypointIndex].position);

        }


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trafficCollider" )
        {

            Debug.Log("Entered");
            //Produce a navmesh, use momentum to allow cars to stop and start

            navMeshAgent.speed =  0;

        }
        else if (other.gameObject.tag == "negativeCollider")
        {
              
                navMeshAgent.speed = 3.5f;
            
        }

      

    }



   // IEnumerator Speedup()
   // {

     //   navMeshAgent.speed = speed = 5f;
     //   yield return new WaitForSeconds(3f);
     //   navMeshAgent.speed = speed = 3.5f;

   // }


    /*

   public List<Transform> wayPoints;
   public List<Transform> carRoutes;

   public int routeNumber = 0;
   public int targetWP = 0;

   public float dist = 0.0f;
   public bool enter = true;
   public bool go = false;
   public float initialDelay;
   public Vector3 velocity;
   public Vector3 displacement;
   public Vector3 newPosition;

   // Start is called before the first frame update
   void Start()
   {
       initialDelay = Random.Range(2.0f, 12.0f);
       transform.position = new Vector3(0.0f, -5.0f, 0.0f);
       wayPoints = new List<Transform>();
       GameObject wayPoint;
       wayPoint = GameObject.Find("Way1");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way2");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way3");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way4");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way5");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way6");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way7");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way8");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way9");
       wayPoints.Add(wayPoint.transform);
       wayPoint = GameObject.Find("Way10");
       wayPoints.Add(wayPoint.transform);




       SetRoute();
   }

   // Update is called once per frame
   void FixedUpdate()
   {
       if (!go)
       {
           initialDelay -= Time.deltaTime;
           if (initialDelay <= 0.0f)
           {
               go = true;
               SetRoute();
           }
           else return;

       }

       displacement = carRoutes[targetWP].position - transform.position;
       displacement.y = 0;
       dist = displacement.magnitude;

       if (dist < 0.1f)
       {
           targetWP++;
           if (targetWP >= carRoutes.Count)
           {
               SetRoute();
               return;
           }
       }

       velocity = displacement;
       velocity.Normalize();
       velocity *= 4.5f;
       Vector3 newPosition = transform.position;

       newPosition += velocity * Time.deltaTime;
       Rigidbody rb = GetComponent<Rigidbody>();
       rb.MovePosition(newPosition);

       Vector3 desiredForward = Vector3.RotateTowards(transform.forward, velocity, 10.0f * Time.deltaTime, 0f);
       Quaternion rotation = Quaternion.LookRotation(desiredForward);
       rb.MoveRotation(rotation);



   }

   void SetRoute()
   {
       routeNumber = Random.Range(0, 5);
       if (routeNumber == 0) carRoutes = new List<Transform> { wayPoints[0], wayPoints[1] };
       else if (routeNumber == 1) carRoutes = new List<Transform> { wayPoints[0], wayPoints[2],wayPoints[3] };
       //else if (routeNumber == 2) carRoutes = new List<Transform> { wayPoints[1], wayPoints[0] };
       else if (routeNumber == 2) carRoutes = new List<Transform> { wayPoints[4], wayPoints[5], wayPoints[1] };
       else if (routeNumber == 3) carRoutes = new List<Transform> { wayPoints[6], wayPoints[9]};
       else if (routeNumber == 4) carRoutes = new List<Transform> { wayPoints[6], wayPoints[7], wayPoints[3] };
       transform.position = new Vector3(carRoutes[0].position.x, 0.0f, carRoutes[0].position.z);
       targetWP = 1;

   }
   */
}
