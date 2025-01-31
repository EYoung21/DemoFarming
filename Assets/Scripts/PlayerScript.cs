using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        //don't want to use positional based because will conflict with rigidbodies

        //if wanted to lsiten for wasd

        // if (Input.GetKey(KeyCode.W)) {
        //     inputY = -1
        // }
        // if (Input.GetKey(KeyCode.A)) {
        //     InputX = -1
        // }
        // if (Input.GetKey(KeyCode.S)) {
        //     inputY = -1
        // }
        // if (Input.GetKey(KeyCode.D)) {
        //     InputY = -1
        // }

        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (input.magnitude > 1.0f) {
            input.Normalize(); //handles diagonal movement
        }
        rb2d.linearVelocity = input * speed;
    }
}
