using UnityEngine;

public class Cube : MonoBehaviour
{

    public float moveSpeed = 5f;


    void Update()
    {
      Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0f);
        transform.Translate(movement * Time.deltaTime * 8f, Space.World);
       // transform.forward = Vector3.Slerp(transform.forward, movement, Time.deltaTime * 8f);
    }
}
