using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
	  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("UFO"))
        {
            Destroy(gameObject);//Destory this Lazerbolt gameobject
			Destroy(other.gameObject);//destory UFO gameobject that is hit
        }
    }
    
}