using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 50.0f;
    public float turnSpeed = 50.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float throttle = Input.GetAxis("Vertical");
        float movement = throttle * speed * Time.deltaTime;

        Transform t = gameObject.transform;
        t.Translate(0.0f, 0.0f, -movement);

        float steering = Input.GetAxis("Horizontal");
        float turn = steering * turnSpeed * Time.deltaTime;
        t.Rotate(0.0f, turn, 0.0f);
    }
}