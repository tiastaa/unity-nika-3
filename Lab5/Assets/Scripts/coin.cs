using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Animator animator;
    private bool isCollected = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isCollected && other.CompareTag("Player"))
        {
            isCollected = true;
            animator.Play("CoinJump");
            Invoke("RotateCoin", 0.5f); // Почати обертання через 0.5 секунди
            Destroy(gameObject, 1f); // Знищити монету через 1 секунду після підбирання
        }
    }

    void RotateCoin()
    {
        animator.Play("CoinRotation");
    }
}
