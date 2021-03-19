using UnityEngine;
public class Mover : MonoBehaviour
{
    [SerializeField] private float speedZ = 6f;
    [SerializeField] private float speedX = 150f;
    public void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime
             * speedZ);
    }
    public void MoveHorizontal(Rigidbody rb, Vector3 directionX)
    {
        rb.velocity += directionX * speedX * Time.fixedDeltaTime;
    }
    public void StopHorizontal(Rigidbody rb)
    {
        rb.velocity = new Vector3(0f, rb.velocity.y, rb.velocity.z);
    }
}
