using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TouchScript;
using TouchScript.Gestures;
using TouchScript.Hit;


public class CamControllerGamePlay : MonoBehaviour
{
    private Transform camTransform;
    private Camera cam;

    public float perspectiveZoomSpeed = 0.5f;        // Speed of zooming in/out.
    public float orthoZoomSpeed = 0.5f;              // Speed of zooming in/out for orthographic camera.
    public float dragSpeed = 0.1f;                   // Speed of dragging the camera.

    private Vector3 dragOrigin;                      // Position where mouse dragging started.
    private bool isDragging;                         // Whether the camera is currently being dragged.

    public float minPanX;
    public float maxPanX;
    public float minPanY;
    public float maxPanY;


    void Start()
    {
        camTransform = GetComponent<Transform>();
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
        {
            // If two fingers are touching the screen, the camera is being zoomed in/out.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            if (cam.orthographic)
            {
                cam.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed;
                cam.orthographicSize = Mathf.Max(cam.orthographicSize, 0.1f);
            }
            else
            {
                cam.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;
                cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, 0.1f, 179.9f);
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            // If left mouse button is clicked, start dragging the camera.
            isDragging = true;
            dragOrigin = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // If left mouse button is released, stop dragging the camera.
            isDragging = false;
        }

        if (isDragging)
        {
            // If the camera is being dragged, update its position.
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);
            transform.Translate(move, Space.World);

            // Limit the camera panning within specified bounds.
            Vector3 clampedPosition = transform.position;
            clampedPosition.x = Mathf.Clamp(transform.position.x, minPanX, maxPanX);
            clampedPosition.y = Mathf.Clamp(transform.position.y, minPanY, maxPanY);
            transform.position = clampedPosition;
        }
    }
}
