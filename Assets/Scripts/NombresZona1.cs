using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NombresZona1 : MonoBehaviour
{
    public GameObject gameManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameManager.GetComponent<GameManager>().Faro();
        }
        
    }
    
    
}
