using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLook : MonoBehaviour {

    public float minVert = -45f;
    public float maxVert = 45f;
    public float hSens = 10f;
    public float vSens = 10f;
    public float _rotationX = 0;
    public GameObject lockVar;

    // Update is called once per frame
    void Update ()
    {
        if (lockVar.name != "True")
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * hSens, 0);
            _rotationX -= Input.GetAxis("Mouse Y") * vSens;
            _rotationX = Mathf.Clamp(_rotationX, minVert, maxVert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }
}
