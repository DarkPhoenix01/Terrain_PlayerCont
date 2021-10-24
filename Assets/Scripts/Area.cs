using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public GameObject effectPreafb;
    public Transform effect1Position;

    
    private bool isNear;
    private bool touch;


    private void Start()
    {
        isNear = false;
        touch=false;
        
    }

    public void StartEffect()
    {
     
            Instantiate(effectPreafb, effect1Position);
        

    }

    
    


    
}
