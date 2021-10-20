using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject effectPreafb;
    //public GameObject effectCatch;
    public Transform effect1Position;
    //public Transform effect2Position;
    
    private bool isNear;
    private bool isOpen;

    private void Start()
    {
        isNear = false;
        //isOpen = false;
        
    }

    public void StartEffect()
    {
        if (isNear == false)
        {
            isNear = true;
            Instantiate(effectPreafb, effect1Position);
        }

        /*if (isOpen == false)
        {
            isOpen = true;
            Instantiate(effectCatch, effect2Position);
        }*/
    }
}
