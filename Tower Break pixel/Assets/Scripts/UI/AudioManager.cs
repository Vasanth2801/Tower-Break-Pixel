using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioClip bgMusic;
    public AudioSource musicSource;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if(bgMusic != null && musicSource != null)
        {
           musicSource.clip = bgMusic;
           musicSource.loop = true;
           musicSource.Play();
        }
    }

}