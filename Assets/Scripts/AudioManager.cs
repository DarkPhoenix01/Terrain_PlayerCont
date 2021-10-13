using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip walk;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource= GetComponent<AudioSource>();
    }

    void Start() 
    {

    }

    public void AudioWalkStart()
    {
        audioSource.clip = walk;
        StartCoroutine(WaitAudioWalk());
    }

    public void AudioWalkStop()
    {
        audioSource.Stop();
    }

    public IEnumerator WaitAudioWalk()
	{
		audioSource.Play();
        yield return new WaitForSeconds(0.576f);
	}
}


