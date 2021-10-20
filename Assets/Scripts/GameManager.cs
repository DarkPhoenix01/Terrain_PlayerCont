using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   
    public int startingTime;
    public int totalTime=50;

    private float pauseTime;
    private float nextTime;
    public Image timeImage;

    public float timePercent
    {
        get {return (float) totalTime / startingTime;}
    }
    
    private void Awake() 
    {
        startingTime=totalTime;    
    }
    
    void Start()
    {
        pauseTime = 1f;  
        nextTime = 0;
        
    }

    
    void Update()
    {
        if (Time.time > nextTime)
        {
           nextTime = Time.time + pauseTime;
           totalTime--;

        }
        timeImage.fillAmount = timePercent;

        if(totalTime<1)
        {
            GameOverPanel();
        }
        if(totalTime<0)
        {
            GameOverPause();
        }
    }

    public void GameOverPause()
    {
        Time.timeScale=(true) ? 0 : 1f;
    }

    public void GameOverPanel()
    {
        
    }
}
