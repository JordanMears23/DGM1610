using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//Destory this gameobject
        Destroy(other.gameObject);//destory gameobject that is hit
    }
}
