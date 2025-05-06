using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 5f;
    public string horizontalInputAxis = "Horizontal";
    public string verticalInputAxis = "Vertical";
    public Rigidbody rb;

    void Update()
    {
        float move = Input.GetAxis(verticalInputAxis) * moveSpeed;
        float turn = Input.GetAxis(horizontalInputAxis) * turnSpeed;
        rb.linearVelocity = transform.forward * move;
        transform.Rotate(0, turn * Time.deltaTime, 0);
    }
}
