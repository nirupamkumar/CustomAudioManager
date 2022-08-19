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

    private void Start()
    {
        AudioManager.Manager.PrintSomething("test print");
    }

    public AudioClip ClipForSFX(SFXClip sfXClip)
    {
        switch (sfXClip)
        {
            case SFXClip.Walking:
                return walkingSFX;
            case SFXClip.spell:
                return spellSFX;
            case SFXClip.Goblin:
                return goblinSFX;
            case SFXClip.Dragon:
                return DragonSFX;
            default:
                return walkingSFX;
        }
    }

    public AudioClip ClipForMusic(MusicClip clips)
    {
        switch (clips)
        {
            case MusicClip.AmbienceCave:
                return caveMusic;
            case MusicClip.Lose:
                return loseMusic;
            case MusicClip.Win:
                return winMusic;
            case MusicClip.Achievement:
                return achievementMusic;
            default:
                return caveMusic;
        }
    }
}
