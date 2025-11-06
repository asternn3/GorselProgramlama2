using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3 (0, 1, -9);

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
