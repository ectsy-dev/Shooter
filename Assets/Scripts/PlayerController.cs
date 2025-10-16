using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody playerRB;
    [SerializeField] Transform cameraTarget;

    internal void Initialize()
    {
        
        playerRB = GetComponent<Rigidbody>();
        cameraTarget = transform.Find("CameraTarget");

    }
    

    public Transform GetCameraTarget() => cameraTarget;

}
