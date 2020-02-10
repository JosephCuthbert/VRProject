using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TrafficLights : MonoBehaviour
{


    [SerializeField]
    private GameObject parent;
    //public GameObject trafficlight;



    public Transform trafficLight1;
    public GameObject child1G;
    public GameObject child1R;
    public GameObject collider_TL1;
    public GameObject _TL1;

    public Transform trafficLight2;
    public GameObject child2G;
    public GameObject child2R;
    public GameObject collider_TL2;
    public GameObject _TL2;

    public Transform trafficLight3;
    public GameObject child3G;
    public GameObject child3R;
    public GameObject collider_TL3;
    public GameObject _TL3;

    public float timer = 20.0f;
    public int lightChange = 0;
    public bool lightChangingBool = true;

    void Start()
    {
        //Finds the gameobjects and saves their positions

        //Sets positions for TL1 and finds the children of the parent object
        trafficLight1 = parent.transform.Find("TL1");
        child1G = trafficLight1.transform.Find("Green light").gameObject;
        child1R = trafficLight1.transform.Find("Red light").gameObject;
        collider_TL1 = trafficLight1.transform.Find("TLCollider").gameObject;
        _TL1 = trafficLight1.transform.Find("TLCollider1").gameObject;
        //Sets positions for TL2 and finds the children of the parent object
        trafficLight2 = parent.transform.Find("TL2");
        child2G = trafficLight2.transform.Find("Green light").gameObject;
        child2R = trafficLight2.transform.Find("Red light").gameObject;
        collider_TL2 = trafficLight2.transform.Find("TLCollider").gameObject;
        _TL2 = trafficLight2.transform.Find("TLCollider2").gameObject;
        //Sets positions for TL3 and finds the children of the parent object
        trafficLight3 = parent.transform.Find("TL3");
        child3G = trafficLight3.transform.Find("Green light").gameObject;
        child3R = trafficLight3.transform.Find("Red light").gameObject;
        collider_TL3 = trafficLight3.transform.Find("TLCollider").gameObject;
        _TL3 = trafficLight3.transform.Find("TLCollider3").gameObject;
        //***********************************************

        //Local boolean that sets the beginning state for the traffic lights
        bool tfLights = true;

        //Sets TF1 to active and TF2 & TF3 to inactive, bar their red lights.
        if (tfLights == true)
        {

            child1G.SetActive(true);

            child1R.SetActive(false);
            child2G.SetActive(false);
            child3G.SetActive(false);
            child2R.SetActive(true);
            child3R.SetActive(true);
            collider_TL1.SetActive(false);
            collider_TL2.SetActive(true);
            collider_TL3.SetActive(true);
            _TL1.SetActive(true);
            _TL2.SetActive(false);
            _TL3.SetActive(false);
            lightChange = 1;
        }


        /*
        else if(child2R.active = false)
        {
            child2G.SetActive(true);
            child1G.SetActive(false);      
            child3G.SetActive(false);
        }
       else if (child3R.active = false)
        {
            child3G.SetActive(true);
            child1G.SetActive(false);
            child2G.SetActive(false);
        }
        
        */

        //Plans for setting up the traffic lights, this helped understand what was meant to be
        //unactive and active

        /*
        child1G.SetActive(false) Turns Green off
        child1R.SetActive(false) Turns Red off
        child1R.SetActive(True) Turns Red On
        child1G.SetActive(True) Turns Green On
        */

    }

    // Update is called once per frame
    void Update()
    {

        if (timer > 0) //Sets the timer, ensuring its over 0
        {
            timer -= Time.deltaTime;
            if (timer < 0) timer = 0;
        }

        if (timer == 0.0f) //Calls a method that is linked to a public bool and secondary methods   
        {                  //This controls the lighting
            TFChanger();
        }

    }

    void TFChanger()
    {

        if (lightChangingBool == false) //Set to true by default, is changed between true and false
        {                           //Between each method, allowing for the switching of the
            TrafficLightChangeR();  //Traffic lights. 

        }
        else if (lightChangingBool == true)
        {
            TrafficLightChange();
        }

    }

    void TrafficLightChange()
    {

        //Changes lights so TF2 is active, and TF1 and TF3 are inactive

        child2G.SetActive(true);
        child3G.SetActive(true);

        collider_TL1.SetActive(true);
        collider_TL2.SetActive(false);
        collider_TL3.SetActive(false);

        _TL1.SetActive(false);
        _TL2.SetActive(true);
        _TL3.SetActive(true);

        child2R.SetActive(false);
        //child3G.SetActive(false);
        child1G.SetActive(false);
        child3R.SetActive(false);
        child1R.SetActive(true);



        lightChange += 1; //Changes the public int to 1 when the method is active
        lightChangingBool = false;

        timer += 20; //Adds 10 seconds to the timer
    }

    void TrafficLightChangeR()
    {
        child1G.SetActive(true);

        collider_TL1.SetActive(false);
        collider_TL2.SetActive(true);
        collider_TL3.SetActive(true);

        _TL1.SetActive(true);
        _TL2.SetActive(false);
        _TL3.SetActive(false);

        child1R.SetActive(false);
        child2G.SetActive(false);
        child3G.SetActive(false);
        child2R.SetActive(true);
        child3R.SetActive(true);



        timer += 20;
        lightChange -= 1;   //Changes the public int to 0 when the method is active
        lightChangingBool = true;
    }
}
