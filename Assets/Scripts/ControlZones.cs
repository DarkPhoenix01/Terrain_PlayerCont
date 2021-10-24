using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlZones : MonoBehaviour
{

    public GameObject gameManager;
    
    public bool chestTouch;
    public int treasure=0;

    void Start()
    {
        chestTouch=false;
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "energy")
        {
            other.gameObject.GetComponent<Zones>().StartEffect();

        } 
        if (other.tag == "ChestArea")
        {
            other.gameObject.GetComponent<Area>().StartEffect();

        }

        if(other.tag == "Chest")
        {
            gameManager.GetComponent<GameManager>().AddTreasure();
            StartCoroutine(Wait());
            if(chestTouch==true)
            {
                other.gameObject.GetComponent<AreaChest>().StartEffect1();
            }
        }

      
    }

    IEnumerator Wait()
    {
        chestTouch=false;
        yield return new WaitForSeconds(0.2f);
        chestTouch=true;
        
    }




}
