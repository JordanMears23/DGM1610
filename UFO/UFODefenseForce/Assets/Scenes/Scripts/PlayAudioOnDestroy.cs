using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnDestroy : MonoBehaviour
{
    public AudioClip audioClip;

    private void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);
    }
}
