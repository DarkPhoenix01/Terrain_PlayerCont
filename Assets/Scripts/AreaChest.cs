using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaChest : MonoBehaviour
{

    public GameObject effectCatch;

    public Transform effect2Position;
    

    private bool isOpen;

    private void Start()
    {

        isOpen = false;
        
    }


    public void StartEffect1()
    {
 
        if (isOpen == false)
        {
            isOpen = true;
            Instantiate(effectCatch, effect2Position);
        }
    }
}
