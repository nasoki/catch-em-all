using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float minX = -10.0f; // Minimum x position
    [SerializeField] private float maxX = 10.0f;  // Maximum x position
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse's x-axis position
        float mouseX = Input.mousePosition.x;

        // Convert the mouse position to world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, 0, 10));

        // Clamp the x position to stay within the specified range
        float clampedX = Mathf.Clamp(mousePosition.x, minX, maxX);

        // Update the object's position along the x-axis
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
