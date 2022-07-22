using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager
{
    private static AudioManager manager;

    public static AudioManager Manager
    {
        get
        {
            return manager;
        }
    }


    public enum Music 
    {  
        AmbienceCave, Lose, Win, Achievement 
    }

    public enum SFX 
    { 
        Walking, spell, Goblin, Dragon 
    }
}
