using System;
using UnityEngine;

public struct CameraInput
{

    public Vector2 Look;

}

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private float cameraSensitivity = 0.1f;

    private Vector3 eulerAngles;

    internal void Initialize(Transform target)
    {

        Cursor.lockState = CursorLockMode.Locked;

        transform.position = target.position;
        transform.eulerAngles = eulerAngles = target.eulerAngles;

    }

    public void UpdatePosition(Transform target)
    {

        transform.position = target.position;

    }

    public void UpdateRotation(CameraInput input)
    {

        eulerAngles += new Vector3(-input.Look.y, input.Look.x, 0f) * cameraSensitivity;
        eulerAngles.x = Mathf.Clamp(eulerAngles.x, -90f, 90f);

        transform.eulerAngles = eulerAngles;

    }


}