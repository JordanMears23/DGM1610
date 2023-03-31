using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
	public ScoreManager scoreManager; //Store reference to score manager 
	public int scoreToGive;


	void Start()
	{
	 scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //Find ScoreManager gameobject and reference ScoreManager script component
	}

	private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("UFO"))
        {	
			scoreManager.IncreaseScore(scoreToGive);// Increases the Score
            Destroy(gameObject);//Destory this Lazerbolt gameobject
			Destroy(other.gameObject);//destory UFO gameobject that is hit
        }

		
    }
   
}