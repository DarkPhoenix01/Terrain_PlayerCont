using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   
    public int startingTime;
    
    public int totalTime=50;
    public int treasure;
    public bool wait=false;

    private float pauseTime;
    private float nextTime;
    public Image timeImage;
    public GameObject GameOverpanel;
    public GameObject Victory;
    public GameObject ovni;
    public GameObject faro;
    public GameObject fabrica;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI treasureText;

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
        ovni.SetActive(false);
        faro.SetActive(false);
        fabrica.SetActive(false);
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
        if (totalTime>=50)
        {
            totalTime=50;
        }
        timeImage.fillAmount = timePercent;
        timerText.text=totalTime.ToString();

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
        GameOverpanel.SetActive(true);
    }

    public void TimeAdd()
    {
        totalTime+=15;
    }

    public void AddTreasure()
    {
        treasure++;
        treasureText.text=treasure.ToString();
        if(treasure==3)
        {
            Victory.SetActive(true);
            Time.timeScale=(true) ? 0 : 1f;
        }
    }

    public void Ovni()
    {
        ovni.SetActive(true);
        StartCoroutine(WaitOvni());
    }

       public void Faro()
    {
        faro.SetActive(true);
        StartCoroutine(WaitFaro());
    }

       public void Fabrica()
    {
        fabrica.SetActive(true);
        StartCoroutine(WaitFabrica());
    }

    IEnumerator WaitOvni()
    {
        wait=false;
        yield return new WaitForSeconds(3f);
        ovni.SetActive(false);
        wait=true;
    }

    IEnumerator WaitFaro()
    {
        wait=false;
        yield return new WaitForSeconds(3f);
        faro.SetActive(false);
        wait=true;
    }

    IEnumerator WaitFabrica()
    {
        wait=false;
        yield return new WaitForSeconds(3f);
        fabrica.SetActive(false);
        wait=true;
    }

    
}
