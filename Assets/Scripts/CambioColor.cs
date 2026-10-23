
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.color = Color.green;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            spriteRenderer.color = Color.yellow;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.color = Color.red;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.color = Color.blue;
        }
    }
}
