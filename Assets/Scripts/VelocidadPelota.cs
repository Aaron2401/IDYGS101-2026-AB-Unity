
using UnityEngine;

public class VelocidadPelota : MonoBehaviour
{
    public float velocidadX = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = new Vector2(velocidadX, 0f);
    }
}
