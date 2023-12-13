using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private Sphere spheree;
    private GameManager gm;
    [SerializeField] Lifes lifes;
    void Start()
    {
        spheree = GameObject.Find("Sphere").GetComponent<Sphere>();
        gm = GameObject.Find("Game Manager").GetComponent< GameManager > ();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(GameObject.FindWithTag("Ball"))
        {
            Destroy(other.gameObject);
            lifes.LostLife();
            spheree.ballisActive = false;
        }
    }
}
