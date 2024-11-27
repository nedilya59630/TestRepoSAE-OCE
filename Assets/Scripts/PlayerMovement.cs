using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 5f;
    private bool isOnGround;
    private new Rigidbody rigidbody;
    private new Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        isOnGround = Physics.Raycast(transform.position + Vector3.up, Vector3.down, 1.1f);
        
        Vector3 velocity = new Vector3(Input.GetAxisRaw("Horizontal") * movespeed, rigidbody.velocity.y, Input.GetAxisRaw("Vertical") * movespeed);
        rigidbody.velocity = velocity;
    }
}
