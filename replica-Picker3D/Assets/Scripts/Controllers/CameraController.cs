using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform picker;
    private float offsetZ;
    private void Start()
    {
        offsetZ = picker.transform.position.z - transform.position.z;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(0,transform.position.y,picker.position.z- offsetZ);
    }
}
