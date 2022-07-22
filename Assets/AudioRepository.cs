using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRepository : MonoBehaviour
{
    [Header("Music")]
    public AudioClip caveMusic;
    public AudioClip loseMusic;
    public AudioClip winMusic;
    public AudioClip achievementMusic;

    [Header("SFX")]
    public AudioClip walkingSFX;
    public AudioClip spellSFX;
    public AudioClip goblinSFX;
    public AudioClip DragonSFX;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
