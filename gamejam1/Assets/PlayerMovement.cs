using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;



    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(-moveX, 0, -moveZ);

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}
