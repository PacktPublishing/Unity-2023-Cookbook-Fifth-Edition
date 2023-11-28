using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public Transform corner_max;
    public Transform corner_min;
    public float speed = 40;
    private Rigidbody rigidBody;
    private float x_min;
    private float x_max;
    private float z_min;
    private float z_max;
    private Vector3 newVelocity;

    void Awake() {
        rigidBody = GetComponent<Rigidbody>();
        x_max = corner_max.position.x;
        x_min = corner_min.position.x;
        z_max = corner_max.position.z;
        z_min = corner_min.position.z;
    }

    private void Update() {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float xSpeed = xMove * speed;
        float zSpeed = zMove * speed;
        newVelocity = new Vector3(xSpeed, 0, zSpeed);
    }

    void FixedUpdate() {
        rigidBody.velocity = newVelocity;
        KeepWithinMinMaxRectangle();
    }

    private void KeepWithinMinMaxRectangle() {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        float clampedX = Mathf.Clamp(x, x_min, x_max);
        float clampedZ = Mathf.Clamp(z, z_min, z_max);
        transform.position = new Vector3(clampedX, y, clampedZ);
    }
}

