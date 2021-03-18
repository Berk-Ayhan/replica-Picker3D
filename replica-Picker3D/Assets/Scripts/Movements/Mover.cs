using UnityEngine;
public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 6f;
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime
             * speed);
    }
}
