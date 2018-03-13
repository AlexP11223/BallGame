using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 6;

    public AudioSource hitSound;

    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        print($"Hit {collision.collider.name}, relativeVelocity: {collision.relativeVelocity.magnitude}");

        if (collision.relativeVelocity.magnitude > 2)
        {
            hitSound.Play();
        }
    }
}