using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones : MonoBehaviour
{
    
    public GameObject effectPreafb;
    public GameObject effectPreafb2;
    public GameObject effectPreafb3;

    public Transform effect1Position;
    public Transform effect2Position;
    public Transform effect3Position;

    private bool isNear;
    
    // Start is called before the first frame update
    void Start()
    {
        isNear=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartEffect()
    {
        if (isNear == false)
        {
            isNear = true;
            Instantiate(effectPreafb, effect1Position);
            isNear=false;
        }

    }

    public void StartEffect1()
    {
        if (isNear == false)
        {
            isNear = true;
            Instantiate(effectPreafb2, effect2Position);
            isNear=false;
        }

    }

    public void StartEffect2()
    {
        if (isNear == false)
        {
            isNear = true;
            Instantiate(effectPreafb3, effect3Position);
            isNear=false;
        }

    }
}
