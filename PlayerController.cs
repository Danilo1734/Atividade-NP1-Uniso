using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _jumpForce = 200;
    [SerializeField] private Rigidbody _rb;

    void Update()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * _speed;
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;

        if (Input.GetKeyDown(KeyCode.Space)) _rb.AddForce(Vector3.up * _jumpForce);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Você perdeu!");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}