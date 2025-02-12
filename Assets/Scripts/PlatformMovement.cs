using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public int speed = 5;

    void Update()
    {
        if (transform.position.x < -20 && gameObject.name == "Platform") {
            transform.position += Vector3.left * 0;
        }
        else
        {
            if (transform.position.x < -20) {
                Destroy(gameObject);
            }
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
