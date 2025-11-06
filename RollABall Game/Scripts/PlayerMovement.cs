using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 50f;
    Rigidbody rb;

    ScoreManager scoreManager;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            scoreManager.CollectPickup();
        }
    }
}
