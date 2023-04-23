using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turning : MonoBehaviour
{
    public bool isLeft = false;
    public float moveSpeed = 5.0f;
    public float maxMoveDistance = 10.0f; // Limit for left or right movement
    public float returnSpeed = 2.0f; // Speed for returning to original position
    private Vector3 originalPosition;
    private bool isMoving = false;
    private Vector3 targetPosition;
    private bool movedLeftReleased = true;
    private bool movedRightReleased = true;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
        {
            if (isLeft)
            {
                if (Input.GetKey("a") || Input.GetKey("z")) // Move left
                {
                    if (movedLeftReleased)
                    {
                        targetPosition = transform.position + Vector3.back * moveSpeed * Time.deltaTime; // Change x to z axis
                        // Clamp target position to limit
                        targetPosition = new Vector3(targetPosition.x, targetPosition.y, Mathf.Clamp(targetPosition.z, originalPosition.z - maxMoveDistance, originalPosition.z)); // Change x to z axis
                        StartCoroutine(MoveToTargetPosition());
                        movedLeftReleased = false;
                    }
                }
                else
                {
                    movedLeftReleased = true;
                }
            }
            else
            {
                if (Input.GetKeyDown("d") || Input.GetKeyDown("x")) // Move right
                {
                    targetPosition = transform.position + Vector3.forward * moveSpeed * Time.deltaTime; // Change x to z axis
                    // Clamp target position to limit
                    targetPosition = new Vector3(targetPosition.x, targetPosition.y, Mathf.Clamp(targetPosition.z, originalPosition.z, originalPosition.z + maxMoveDistance)); // Change x to z axis
                    StartCoroutine(MoveToTargetPosition());
                }
            }
        }

        // Drift back to original position
        if (!isMoving)
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, returnSpeed * Time.deltaTime);
        }
    }



    IEnumerator MoveToTargetPosition()
    {
        isMoving = true;
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f);
            yield return null;
        }
        transform.position = targetPosition;
        isMoving = false;
    }
}
