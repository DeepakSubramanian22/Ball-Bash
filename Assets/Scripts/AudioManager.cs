using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;
    public AudioClip hitSound;
    public AudioClip HardHitSound;
    public AudioClip gameOverSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayBackgroundMusic();
    }

    public void PlayBackgroundMusic()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayHitSound()
    {
        sfxSource.PlayOneShot(hitSound);
    }

    public void PlayGameOverSound()
    {
        musicSource.Stop();
        sfxSource.clip = gameOverSound;
        sfxSource.loop = false;
        sfxSource.Play();
    }

    public void PlayHardHitSound()
    {
        sfxSource.PlayOneShot(HardHitSound);
    }
}