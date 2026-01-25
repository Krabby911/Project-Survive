using UnityEngine;


public class playerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX, moveY;
    [SerializeField] float moveSpeed = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
{
    // Check Vertical
    if (Input.GetKey(KeyCode.W)) { moveY = 1; }
    else if (Input.GetKey(KeyCode.S)) { moveY = -1; }
    else { moveY = 0; }

    // Check horizontal
    if (Input.GetKey(KeyCode.A)) { moveX = -1; }
    else if (Input.GetKey(KeyCode.D)) { moveX = 1; }
    else { moveX = 0; }
}

    // Update is called fixed amount of times
    void FixedUpdate()
    {
       rb.linearVelocity = new Vector2(moveX, moveY).normalized * moveSpeed;
    }
}
