using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAudioPlayer
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    public enum Music { CombatMusic, BackGroundMusic, MenuMusic }

    public enum SoundFX { Hit, Walking, Running }


    public static void PlayGameMusic(Music music)
    {
        if (music == Music.CombatMusic)
            Debug.Log("Combat music is playing");
        else if (music == Music.BackGroundMusic)
            Debug.Log("Background music is playing");
        else if (music == Music.MenuMusic)
            Debug.Log("Main menu music is playing");
    }

    public static void PlayGameSoundFX(SoundFX soundFX)
    {
        if (soundFX == SoundFX.Hit)
            Debug.Log("Player fired the gun");
        else if (soundFX == SoundFX.Running)
            Debug.Log("Player is running");
        else if (soundFX == SoundFX.Walking)
            Debug.Log("Player is walking");
    }


}
