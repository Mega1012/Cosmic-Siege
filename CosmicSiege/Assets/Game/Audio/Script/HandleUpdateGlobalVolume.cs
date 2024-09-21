using System.Collections;
using UnityEngine;
using static AudioSourceController;
[RequireComponent(typeof(AudioSource))]
public class HandleUpdateGlobalVolume : MonoBehaviour
{
    [Header("Audios")]
    [SerializeField] protected AudioSource audioSource;
    [SerializeField] protected AudioClip[] audioClip;
    public bool IsVolumeOk { get; set; } = false;
    public bool PlayOnAwake { get; set; } = false;

    private void Awake()
    {
        StartCoroutine(SubscribeInAudioEvent());
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null && audioClip.Length > 0 && audioSource.clip == null)
        {
            audioSource.clip = audioClip[0];
        }
        audioSource.volume = OptionsRepository.GetVolumeMaster;
    }
    public IEnumerator SubscribeInAudioEvent()
    {
        yield return new WaitForSeconds(instanceAudioSourceController.timeBeforeSubscribe);
        instanceAudioSourceController.HandleUpdateVolume += VolumeUpdate;
        IsVolumeOk = true;
    }

    public void VolumeUpdate(float volume)
    {
        audioSource.volume = volume;
    }
    public void PlayAudio(int index, float volumeTimeStartAt = 0)
    {
        if (audioClip.Length <= index)
        {
            Debug.Log("Index de áudio acessado inválido");
            return;
        }
        audioSource.clip = audioClip[index];
        audioSource.time = audioSource.clip.length - 0.15f > volumeTimeStartAt ? volumeTimeStartAt : 0;
        audioSource.Play();
    }
    public void LoopAudio(bool loop)
    {
        audioSource.loop = loop;
    }
    private void OnDestroy()
    {
        instanceAudioSourceController.HandleUpdateVolume -= VolumeUpdate;
    }
}
