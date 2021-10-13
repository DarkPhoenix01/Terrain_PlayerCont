using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip walk;
    public bool isWalking;
    private AudioSource audioSource;
    
    void Awake()
    {
        audioSource= GetComponent<AudioSource>();
    }

    void Start() 
    {
        isWalking = false;
    }

    public void AudioWalk()
    {
        isWalking = true;
        StartCoroutine(WaitAudioWalk());
    }


    public IEnumerator WaitAudioWalk()
	{
        audioSource.PlayOneShot(walk, 1f);
        yield return new WaitForSeconds(1.576f);
        isWalking = false;
    }

    private void Update() 
    {
       if (isWalking == true){
            AudioWalk();
        }
    
    }
}


