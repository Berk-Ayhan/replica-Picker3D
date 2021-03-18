using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerController : MonoBehaviour
{
    Rigidbody _rb;
    Mover _mover;

    Vector3 first, second;
    public float speed = 2;
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _mover = GetComponent<Mover>();
    }
    void FixedUpdate()
    {
        _mover.Move();
        if (Input.GetMouseButtonDown(0))
        {
            first = Camera.main.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, 0, 0));
        }
        //to-do: duvarlara çarpýnca duran script yazýlacak
        if (Input.GetMouseButton(0))
        {
            second = Camera.main.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, 0, 0));
            Vector3 diff = second - first;
            _rb.velocity += diff * speed;
            first = second;
        }
    }
}
