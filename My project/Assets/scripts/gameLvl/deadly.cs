using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class deadly : MonoBehaviour
{
    public top topitop;
    public float amplitude = 2f; // Genlik
    public float frequency = 1f; // Frekans
    private Vector3 initialPosition;
    public int which;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (which == 1)
        { 
        float x = initialPosition.x + amplitude * Mathf.Sin(2f * Mathf.PI * frequency * Time.time);
        transform.position = new Vector3(x, initialPosition.y, initialPosition.z);
        }
        else
        {
            float y = initialPosition.y + amplitude * Mathf.Sin(2f * Mathf.PI * frequency * Time.time);
            transform.position = new Vector3(initialPosition.x,y, initialPosition.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            topitop.YourDead();
            Destroy(collision.gameObject);
        }
    }
}

