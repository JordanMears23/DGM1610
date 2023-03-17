using UnityEngine;

public class PickupItemController : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Add code later that gives some sort of effects or bonus
            Destroy(gameObject);
        }
    }
}