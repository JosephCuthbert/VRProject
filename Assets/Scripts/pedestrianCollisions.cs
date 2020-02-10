using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedestrianCollisions : MonoBehaviour
{
    private GameObject parentPedestrian;


    public List<GameObject> pedestrianGO = new List<GameObject>();

    public GameObject objectToMove;
  //  public GameObject[] pedestrianGO;
     public GameObject _Pedestrians;
    public Vector3 moveDirection;
    
    void Start()
    {
      
    }


    void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Collision");

       
        //  objectToMove.transform.position += moveDirection;
        // other.GetComponent<Collider>().enabled = false;




    }
     void OnTriggerExit(Collider other)
    {
       // other.GetComponent<Collider>().enabled = true;
        Debug.Log("Collision Exit");
    }
}
