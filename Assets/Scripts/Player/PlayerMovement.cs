using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 1;
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(x: -0.1f * moveSpeed, y: 0f, z: 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(x: 0.1f * moveSpeed, y: 0f, z: 0f);
        }
    }

}
