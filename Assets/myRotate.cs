using UnityEngine;

public class myRotate : MonoBehaviour
{

    // Update is called once per frame
    float rotSpeed =  20;
    void OnMouseDrag() {
        float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;   
        float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;   

        transform.RotateAround(Vector3.up,-rotX);
        transform.RotateAround(Vector3.right,rotY);
    }
}