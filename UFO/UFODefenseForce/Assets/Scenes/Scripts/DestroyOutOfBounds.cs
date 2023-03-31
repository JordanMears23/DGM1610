using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;
	public GameManager gameManager; //Store reference to GameManager
	public AudioClip endAudio;
	
void Start()
{
	gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference GameManager Script
}
   
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds && gameObject.CompareTag("UFO"))
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
			gameManager.isGameOver = true;

        }
		if(gameManager.isGameOver == true)
		{
			AudioSource.PlayClipAtPoint(endAudio, transform.position);
		}
    }
}