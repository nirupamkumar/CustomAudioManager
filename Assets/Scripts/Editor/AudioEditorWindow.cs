using UnityEngine;
using UnityEditor;

public class AudioEditorWindow : EditorWindow
{
    public AudioClip audioClip;
    public float fadeIn;
    public float fadeOut;
    public int volume;

    [MenuItem("AudioPlayer/AudioPlayerEditor")]
    public static void ShowEditorWindow()
    {
        GetWindow<AudioEditorWindow>("AudioPlayerEditor");
    }

    private void OnGUI()
    {
        GUILayout.Label("Audio Player", EditorStyles.boldLabel);

        audioClip = (AudioClip)EditorGUILayout.ObjectField("Clip", audioClip, typeof(AudioClip), false);

        GUILayout.Label("Audio Funcationalities", EditorStyles.helpBox);
        fadeIn = EditorGUILayout.Slider("Fade In", fadeIn, 0f, 1f);
        fadeOut = EditorGUILayout.Slider("Fade Out", fadeOut, -1f, 0f);

        volume = (int)EditorGUILayout.Slider("Volume", volume, 0, 10);
        
        
    }
}
