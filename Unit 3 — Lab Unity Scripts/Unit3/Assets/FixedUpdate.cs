using UnityEngine;
using System.Collections;

public class FixedUpdate : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    
    
    void Update ()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}