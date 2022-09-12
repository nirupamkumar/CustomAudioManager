using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AudioManager
{
    private AudioSource audioSourceMusic;
    private AudioSource audioSourceSounds;

    private AudioRepository repository;

    [Range(0f, 1f)] 
    private float fadeIn;
    [Range(0f, 1f)] 
    private float fadeOut;
    [Range(0f, 1f)] 
    private float volume;

    //-----Singleton
    private static AudioManager _manager;

    public static AudioManager Manager
    {
        get
        {
            if(_manager != null)
            {
                return _manager;
            }
            else
            {
                //-----isMusic
                var audioManagerGOMusic = new GameObject();
                audioManagerGOMusic.name = "Audio Manager Music";
                var audioSourceComponentMusic = audioManagerGOMusic.AddComponent<AudioSource>();
                audioSourceComponentMusic.loop = true;
                GameObject.DontDestroyOnLoad(audioManagerGOMusic);

                _manager = new AudioManager();
                _manager.audioSourceMusic = audioSourceComponentMusic;

                //-----isSounds
                var audioManagerGoSounds = new GameObject();
                audioManagerGoSounds.name = "Audio Manager Sounds";
                var audioSourceComponentSounds = audioManagerGoSounds.AddComponent<AudioSource>();
                GameObject.DontDestroyOnLoad(audioManagerGoSounds);

                _manager.audioSourceSounds = audioSourceComponentSounds;

                _manager.repository = GameObject.FindObjectOfType<AudioRepository>();

                return _manager;
            }
           
        }
    }

    #region Music
    public void PlayMusic(MusicClip musicClip)
    {
        //audioSourceMusic.PlayOneShot(repository.ClipForMusic(musicClip));

        audioSourceMusic.loop = true;
        audioSourceMusic.clip = repository.ClipForMusic(musicClip);
        audioSourceMusic.Play();
    }
    #endregion


    #region SFX
    public void PlaySFX(SFXClip fXClip)
    {
        audioSourceSounds.PlayOneShot(repository.ClipForSFX(fXClip));
    }

    public void PlaySFX(SFXClip fXClip, Vector3 vector3)
    {
        audioSourceSounds.PlayOneShot(repository.ClipForSFX(fXClip));
    }
    #endregion


    public void FadeIn(float value)
    {
        _manager.fadeIn = value;
    }

    public void FadeOut(float value)
    {
        _manager.fadeOut = value;
    }


    public void PrintSomething(string name)
    {
        Debug.Log("Print something");
    }

}


//enum's
public enum MusicClip
{
    AmbienceCave, Lose, Win, Achievement
}

public enum SFXClip
{
    Walking, spell, Goblin, Dragon
}

