using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlZones : MonoBehaviour
{

    public GameObject gameManager;
    public Animator animation;
    public bool chestTouch;

    void Start()
    {
        chestTouch=false;
        animation=GetComponent<Animator>();
        animation.SetBool("Open", false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chest")
        {
            other.gameObject.GetComponent<Door>().StartEffect();
            chestTouch=true;
            
        }
   
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Chest")
        {
            animation.SetBool("Open", true);
        }
    }



}
