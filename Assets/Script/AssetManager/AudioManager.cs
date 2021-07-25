using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    #region Singleton
    public static AudioManager Instance = null;

    [Serializable]

    public class Sound
    {
        public string name;
        public AudioClip thisClip;
        [HideInInspector]
        public AudioSource source;
        public float volume;
        public bool loop;
        public bool playOnAwake;
    }

    public List<Sound> soundList;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        foreach(Sound sound in soundList)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.thisClip;
            sound.source.volume = sound.volume;
            sound.source.loop = sound.loop;
            sound.source.playOnAwake = sound.playOnAwake;
        }
        this.PlaySound("background");
    }
    #endregion
    public void PlaySound(string name)
    {
        foreach (Sound sound in soundList)
        {
            if (sound.name.CompareTo(name) == 0)
            {
                sound.source.Play();
                break;
            }
                
        }

    }
}
