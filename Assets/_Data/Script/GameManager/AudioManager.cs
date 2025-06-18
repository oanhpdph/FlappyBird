using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance => instance;
    [SerializeField] private AudioSource m_AudioSourceHit;
    [SerializeField] private AudioSource m_AudioSourcePoint;
    [SerializeField] private AudioSource m_AudioSourceWing;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PlayAudioHit()
    {
        m_AudioSourceHit.Play();
    }
    public void PlayAudioPoint()
    {
        m_AudioSourcePoint.Play();
    }
    public void PlayAudioWing()
    {
        m_AudioSourceWing.Play();
    }
}