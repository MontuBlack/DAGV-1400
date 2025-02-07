using UnityEngine;

public class SimpCharCon : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform thisTransform;
    public Vector3 movementVector = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        thisTransform = transform;  // Directly assign the transform of this GameObject
    }

    // Update is called once per frame
    public void Update()
    {
        MoveCharacter();
        KeepCharacterOnAxis();
    }

    public void MoveCharacter()
    {
        movementVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movementVector = movementVector * moveSpeed * Time.deltaTime;
        thisTransform.Translate(movementVector);
    }

    public void KeepCharacterOnAxis()
    {
        // Corrected variable name: currentPosition
        Vector3 currentPosition = thisTransform.position;
        currentPosition.z = 0f;  // Keep the Z-axis at 0
        thisTransform.position = currentPosition;
    }
}
