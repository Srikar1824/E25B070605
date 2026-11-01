
using UnityEngine;

public class cacher : MonoBehaviour
{
    public float speed = 10f;
    public float limit = 8f;

    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");

        transform.Translate(
            speed * input * Vector3.right * Time.deltaTime
        );

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -limit, limit);

        transform.position = pos;
    }
}
