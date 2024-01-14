using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SFXAudioTimer : MonoBehaviour
{

    [Range(0,1000)] public int minimalDistance = 100;
    [Range(0,1000)] public int maximalDistance = 100;

    [Range(0f,1f)] public float volume = 1f;

    public List<AudioClip> audioFiles = new List<AudioClip> ();
    private AudioSource audioSource = null;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
        audioSource = this.GetComponent<AudioSource> ();
        }
        catch
        {
            print("No AudioSource found and assigned!");
            return;
        }

        if(audioFiles.Count <= 0)
        {
            print("No audio files assigned!");
            return;
        }

        AdjustAudioSourceSettings();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateBasicAudio();

        //randomize new audio file
        int f = Random.Range(audioFiles.Count, 1);
        //print(f);

        //check if clip is currently running, if not then randomize audio file and play
        if(!audioSource.isPlaying)
        {
            audioSource.clip = audioFiles[f];
            audioSource.Play();
        }

    }

    void AdjustAudioSourceSettings()
    {
        //clean settings and set optimal settings
        audioSource.clip = null;
        audioSource.priority = 128;
        audioSource.spatialBlend = 1;
        audioSource.volume = volume;
        audioSource.dopplerLevel = 1;
        audioSource.spread = 30;
        audioSource.loop = false;
        audioSource.playOnAwake = false;
        audioSource.rolloffMode = AudioRolloffMode.Logarithmic;
        audioSource.reverbZoneMix = 1;
        audioSource.minDistance = minimalDistance;
        audioSource.maxDistance = maximalDistance;
    }

    void UpdateBasicAudio()
    {
        audioSource.volume = volume;
        audioSource.minDistance = minimalDistance;
        audioSource.maxDistance = maximalDistance;
    }
}
