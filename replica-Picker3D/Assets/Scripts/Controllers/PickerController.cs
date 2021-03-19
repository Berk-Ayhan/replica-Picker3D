using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerController : MonoBehaviour
{
    private Rigidbody _rb;
    private Mover _mover;
    private Vector3 _directionX;
    private float _mouseXPos;
    private bool _isClicked;
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _mover = GetComponent<Mover>();
    }
    void Update()
    {
        _mouseXPos = Input.GetAxis("Mouse X");
        _directionX = new Vector3(_mouseXPos, 0, 0);
        CheckMouseClick();
    }
    void FixedUpdate()
    {
        _mover.MoveForward();
        if (_isClicked)
        {
            if (_mouseXPos != 0)
            {
                _mover.MoveHorizontal(_rb ,_directionX);
            }
            else
            {
                _mover.StopHorizontal(_rb);
            }
        }
        else
        {
            _mover.StopHorizontal(_rb);
        }        
    }
    private void CheckMouseClick()
    {
        if (Input.GetMouseButton(0))
            _isClicked = true;
        else
            _isClicked = false;
    }
}

