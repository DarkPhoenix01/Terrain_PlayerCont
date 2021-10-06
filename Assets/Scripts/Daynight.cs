using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daynight : MonoBehaviour
{

    
   
   public int rotationScale=10;



    void FixedUpdate()
    {
        transform.Rotate(rotationScale*Time.deltaTime,0,0);
    }
}
