using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance
    {
        get{return instance;}
        private set{instance = value;}
    }

    private AudioSource audioSource;

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this); // Destroy marks objects for destruction
            return;
        }

        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySFX(AudioClip clip, float volumeScale)
    {
        audioSource.PlayOneShot(clip, volumeScale);
    }
}
