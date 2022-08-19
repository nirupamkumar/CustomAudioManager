using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager
{
    private AudioSource audioSourceMusic;
    private AudioSource audioSourceSounds;
    private AudioRepository repository;

    //private Transform playerTransform;

    [Range(0f, 1f)] private float fadeIn;
    [Range(0f, 1f)] private float fadeOut;

    [Range(0f, 1f)] private float volume;

    private static AudioManager manager;

    public static AudioManager Manager
    {
        get
        {
            if(manager != null)
            {
                return manager;
            }
            else
            {
                var audioManagerGO = new GameObject();
                audioManagerGO.name = "Audio Manager";
                var audioSourceComponent = audioManagerGO.AddComponent<AudioSource>();
                GameObject.DontDestroyOnLoad(audioManagerGO);

                manager = new AudioManager();
                manager.audioSourceMusic = audioSourceComponent;

                manager.repository = GameObject.FindObjectOfType<AudioRepository>();

                //GameObject go = GameObject.Find("PlayerCapsule");
                //manager.playerTransform = go.GetComponent<Transform>();

                return manager;
            }
           
        }
    }

    public void PlaySFX(SFXClip fXClip)
    {
        audioSourceMusic.PlayOneShot(repository.ClipForSFX(fXClip));
    }

    public void PlayMusic(MusicClip musicClip)
    {
        audioSourceMusic.PlayOneShot(repository.ClipForMusic(musicClip));
    }

    public void PlayerPosition(SFXClip clip, Transform transform)
    {
        audioSourceMusic.PlayOneShot(repository.ClipForSFX(clip));
    }



    public void FadeIn(float value)
    {
        manager.fadeIn = value;
    }

    public void FadeOut(float value)
    {
        manager.fadeOut = value;
    }

    public void GameVolume(AudioSource source, float volume)
    {
       source.volume = volume;
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

