using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    Rigidbody _rigidbody;
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(Vector3.up * 500);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _rigidbody.velocity = new Vector3(collision.gameObject.GetComponent<Rigidbody>().velocity.x, _rigidbody.velocity.y, _rigidbody.velocity.z);
        }

        if (collision.gameObject.CompareTag("Brick"))
        {
            if (transform.position.y <2)
                gameController.PointCounter("text2");
            if (transform.position.y >10)
                gameController.PointCounter("text1");
        }
      


    }
}
