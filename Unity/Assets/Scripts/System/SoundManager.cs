using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundManager Instance;
    
    public TMP_Text volumetxt;
    public Slider volumeslider;
    public AudioSource background;

    public SO_Sound sound;
    
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        SetVolume();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeVolume();
    }

    public void ChangeVolume()
    {
        float volume = volumeslider.value * 100;
        volumetxt.text = volume.ToString();
        sound.backgroundvolume = volumeslider.value;
        background.volume = sound.backgroundvolume;
    }

    public void SetVolume()
    {
        volumeslider.value = sound.backgroundvolume;
        background.volume = sound.backgroundvolume;
    }
}
