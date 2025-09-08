using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-time seconds a full day lasts (e.g., 120 = 2 minutes).")]
    public float dayLengthInSeconds = 120f;

    private float rotationSpeed;

    void Start()
    {
        // One full rotation (360°) per "day"
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        // Rotate around the X-axis at the proper speed
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
