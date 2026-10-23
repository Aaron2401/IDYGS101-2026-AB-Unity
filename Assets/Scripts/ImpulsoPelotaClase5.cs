
using UnityEngine;

public class ImpulsoPelotaClase5 : MonoBehaviour
{
    public float fuerza = 7f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }
    }
}
