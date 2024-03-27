using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    AudioSource m_AudioSource;
    public AudioClip[] audioClips;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void GetHit()
    {
        AudioClip clip = audioClips[Random.Range(0, audioClips.Length)];
        m_AudioSource.PlayOneShot(clip);
        GameManager.Instance.UpdateScore();
    }
}
