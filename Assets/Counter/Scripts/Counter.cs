using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Counter : MonoBehaviour
{

    private Sphere spheree;
    private GameManager gm;

    private void Start()
    {
       
        spheree = GameObject.Find("Sphere").GetComponent<Sphere>();
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindWithTag("Ball"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
          
        }
        gm.CounterPoint();
        spheree.ballisActive = false;
    }

    

}
