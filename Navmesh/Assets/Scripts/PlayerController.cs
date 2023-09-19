using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  Rigidbody rb;
  [SerializeField] float movementSpeed = 6f;

  private void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  private void Update()
  {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
  }

  private void GameOver()
  {
    if (collision.gameObjectt.tag == "Enemy")
    {
      Debug.Log("Game Over!");
    }
  }
}
