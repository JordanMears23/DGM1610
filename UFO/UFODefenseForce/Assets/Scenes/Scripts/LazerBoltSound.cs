using UnityEngine;

public class LazerBoltSound : MonoBehaviour
{
    public AudioClip soundEffect;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        }
    }
}

//FIX lazerbolt makes sound after game is over