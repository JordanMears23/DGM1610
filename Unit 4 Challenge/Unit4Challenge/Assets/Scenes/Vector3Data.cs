using UnityEngine;

public class Vector3Data : MonoBehaviour
{
    private float moveSpeed = 5f;

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (horizontalInput != 0)
        {
            transform.position += Vector3.right * horizontalInput * moveSpeed * Time.deltaTime;
        }
    }
}