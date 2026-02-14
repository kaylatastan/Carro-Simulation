using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [Header("Assignments")]
    [Tooltip("Drag the Main Camera here")]
    public Transform cameraObject;

    [Tooltip("Drag the Player or Object to follow here")]
    public Transform targetObject;

    // This stores the initial distance between the camera and the target
    private Vector3 _initialOffset;

    void Start()
    {
        // 1. Calculate the offset based on where you placed the camera in the Scene view
        if (cameraObject != null && targetObject != null)
        {
            _initialOffset = cameraObject.position - targetObject.position;
        }
        else
        {
            Debug.LogWarning("Please assign both the Camera and the Target in the Inspector.");
        }
    }

    void LateUpdate()
    {
        // 2. Move the camera to the target's position + the initial offset
        if (cameraObject != null && targetObject != null)
        {
            cameraObject.position = targetObject.position + _initialOffset;
        }
    }
}