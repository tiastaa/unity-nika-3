using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private float speed = 3;
    private float jumpForce = 3f;
    private bool onGround = true;
    private Rigidbody playerRb;
    private float horizontalInput;
    private float verticalInput;
    public Transform EndPoint;
    private bool isSpeedBoostActive = false;
    private float speedBoostDuration = 5f;
    private float speedBoostAmount = 17f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * (isSpeedBoostActive ? speedBoostAmount : speed) * horizontalInput);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * (isSpeedBoostActive ? speedBoostAmount : speed) * verticalInput);
        
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(ActivateSpeedBoost());
        }
    }

    private IEnumerator ActivateSpeedBoost()
    {
        isSpeedBoostActive = true;
        yield return new WaitForSeconds(speedBoostDuration);
        isSpeedBoostActive = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
