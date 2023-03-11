using UnityEngine;
using UnityEngine.Events;

public class SquareJump : MonoBehaviour
{
    public UnityEvent Jump;
    public AudioClip Sound;
    public UnityEvent ColorChange;
    private Rigidbody2D rb;
    private AudioSource audioSource;
    private Renderer rend;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 3f, ForceMode2D.Impulse);
            Jump.Invoke();
            PlaySound();
            ChangeColor();
        }
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(Sound);
    }

    public void ChangeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        rend.material.color = newColor;
        ColorChange.Invoke(); 
    }
}