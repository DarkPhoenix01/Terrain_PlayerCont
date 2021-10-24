using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject objeto;
    public Animation animation;
    // Start is called before the first frame update
    void Start()
    {
  

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player" )
        {
            objeto.SetActive(true);
            animation.enabled=true;
            
        }

       
   
    }
}
