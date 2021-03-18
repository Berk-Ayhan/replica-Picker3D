using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerController : MonoBehaviour
{
    Mover _mover;
    void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _mover.Move();
    }
}
