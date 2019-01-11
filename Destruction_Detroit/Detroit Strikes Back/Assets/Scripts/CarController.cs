using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    public float curroty;
    public float curposz;
    public float curposx;
    public float curposy;
    public GameObject car;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float curroty = car.transform.rotation.eulerAngles.y;
        float curposz = car.transform.position.z;
        float curposx = car.transform.position.x;
        float curposy = car.transform.position.y;
        if ((Input.GetKey(KeyCode.W)&&(!Input.GetKey(KeyCode.A)))||(Input.GetKey(KeyCode.W)&&(!Input.GetKey(KeyCode.D))))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if ((Input.GetKey(KeyCode.S) && (!Input.GetKey(KeyCode.A))) || (Input.GetKey(KeyCode.S) && (!Input.GetKey(KeyCode.D))))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            rb.rotation = Quaternion.Euler(0, curroty - 2.5f, 0);
            transform.position += transform.forward * Time.deltaTime * (speed-45.0f);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            rb.rotation = Quaternion.Euler(0, curroty + 2.5f, 0);
            transform.position += transform.forward * Time.deltaTime * (speed-45.0f);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            rb.rotation = Quaternion.Euler(0, curroty + 2.5f, 0);
            transform.position += transform.forward * Time.deltaTime * (speed - 45.0f);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            rb.rotation = Quaternion.Euler(0, curroty - 2.5f, 0);
            transform.position += transform.forward * Time.deltaTime * (speed - 45.0f);
        }

    }
}