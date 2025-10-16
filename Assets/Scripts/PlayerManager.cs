using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] PlayerController playerController;
    [SerializeField] PlayerCamera playerCamera;

    private PlayerInputs playerInputs;

    public void Start()
    {

        playerInputs = new PlayerInputs();
        playerInputs.Enable();

        playerController.Initialize();
        playerCamera.Initialize(playerController.GetCameraTarget());

    }

    private void OnDestroy()
    {

        playerInputs.Dispose();

    }

    private void Update()
    {

        var input = playerInputs.Gameplay;

        var cameraInput = new CameraInput
        {

            Look = input.Look.ReadValue<Vector2>(),

        };

        playerCamera.UpdateRotation(cameraInput);

    }

    private void FixedUpdate()
    {
        


    }

    private void LateUpdate()
    {
        
        playerCamera.UpdatePosition(playerController.GetCameraTarget());

    }

}
