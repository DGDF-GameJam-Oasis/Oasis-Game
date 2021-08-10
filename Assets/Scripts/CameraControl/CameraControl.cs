using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    private Camera Cam;
    private Vector3 DragOrigin;

    private void Update()
    {
        PanCamera();
    }

    private void PanCamera()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DragOrigin = Cam.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0))
        {
            Vector3 Difference = DragOrigin - Cam.ScreenToWorldPoint(Input.mousePosition);
            Cam.transform.position += Difference;
        }
    }
}
