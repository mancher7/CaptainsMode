using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        var spf = speed * Time.deltaTime;

        transform.position += transform.up * (v * spf);
        transform.position += transform.right * (h * spf);
    }
}
