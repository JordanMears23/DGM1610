using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 33;

    public Transform blaster;
    public GameObject lazerBolt;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference gamemanager script on gamemanager object
    }
    
    void Update()
    {
        //Set horizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        //moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
       //keep player within bounds leftside
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //keep player within bounds rightside
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //if spacebar is pressed fire lazerbolt
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) // Second condition gamemamanger.isgameover prevents the player from shooting after isgameover becomes active
        {
            //create lazerbolt at the blaster transform position maintaining the object rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }
    //Delte any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
