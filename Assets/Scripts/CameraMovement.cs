using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMovement : MonoBehaviour
{
    public Transform target;

    public float RotationSpeed = 500.0f;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.visible = false;
            CamRotation();
        }
        
        else
        {
            Cursor.visible = true;
        }
    }

    private void CamRotation()
    {

        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            float verticalInput = Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime;
            float horizontalInput = Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime;
            transform.RotateAround(target.position, Vector3.up, horizontalInput);
            transform.RotateAround(target.position, transform.right, -verticalInput);
        }
    }

}
