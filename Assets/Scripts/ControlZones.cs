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
        animation.SetBool(Open, false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chest")
        {
            other.gameObject.GetComponent<Door>().StartEffect();
            chestTouch=true;
            if(Input.GetKeyDown(KeyCode.E))
            {
            chestTouch=false;
            animation.SetBool("Open", true);
            }
        }
        
    }



}
