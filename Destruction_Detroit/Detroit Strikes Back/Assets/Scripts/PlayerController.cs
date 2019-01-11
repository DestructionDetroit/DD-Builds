using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    public float curroty;
    public float curposz;
    public float curposx;
    public float curposy;
    public GameObject player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float curroty = player.transform.rotation.eulerAngles.y;
        float curposz = player.transform.position.z;
        float curposx = player.transform.position.x;
        float curposy = player.transform.position.y;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown("e"))
        {
            rb.rotation = Quaternion.Euler(0, curroty + 90.0f, 0);
        }
        if (Input.GetKeyDown("q"))
        {
            rb.rotation = Quaternion.Euler(0, curroty - 90.0f, 0);
        }

    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(0, 7, 0);
        }
    }
}