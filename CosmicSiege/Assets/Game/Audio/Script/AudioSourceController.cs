using System.Collections;
using UnityEngine;

public class AudioSourceController : MonoBehaviour
{
    public static AudioSourceController instanceAudioSourceController;
    public delegate void UpdateGlobalVolume(float volume);
    public event UpdateGlobalVolume HandleUpdateVolume;
    
    public bool IsVolumeLoaded { get; set; } = false;
    public float timeBeforeSubscribe = 0.1f;

    private void Awake()
    {
        instanceAudioSourceController = this;
        StartCoroutine(StartUpdateVolumeMaster());
    }

    public void SetGlobalVolume()
    {
        float updateVolume = OptionsRepository.GetVolumeMaster;
        if (updateVolume < 0 || updateVolume > 1)
        {
            updateVolume = 0.25f;
            OptionsRepository.SaveVolumeMaster(updateVolume);
        }
        HandleUpdateVolume?.Invoke(updateVolume);
    }

    public IEnumerator StartUpdateVolumeMaster()
    {
        yield return new WaitForSeconds(timeBeforeSubscribe * 2);
        SetGlobalVolume();
        IsVolumeLoaded = true;
    }
}
