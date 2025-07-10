using UnityEngine;

public class Oscillator : MonoBehaviour
{
        [SerializeField] Vector3 movementVector;
        [SerializeField] float speed;

        Vector3 StartPosition;
        Vector3 endPosition;
        float movementFactor;

    void Start()
    {
        StartPosition = transform.position;
        endPosition = StartPosition + movementVector;
    }

    void Update()
    {
        movementFactor = Mathf.PingPong(Time.time * speed, 1f);
        transform.position = Vector3.Lerp(StartPosition, endPosition, movementFactor);
    }
}
