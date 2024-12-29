using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngineInternal;

public class top : MonoBehaviour
{
    public float hareketHizi = 5f;
    public float ziplamaGucu = 10f;
    private Rigidbody2D rb;
    bool canPlay;
    public panelManager pManager;


    public int puan = 0;


  
    void Start()
    {
        canPlay = true;
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Move();
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            puan++;
        }
        else if (other.CompareTag("Finish"))
        {
            canPlay = false;
            pManager.PanelCikar(puan);
        }
    }
    void bok()
    {
        Debug.Log("bok");
    }
    public void Move()
    {
        if (canPlay)
        {
            // Yatay hareket
            float yatayInput = Input.GetAxis("Horizontal");
            Vector2 hareket = new Vector2(yatayInput * hareketHizi, rb.velocity.y);
            rb.velocity = hareket;

            // Zýplama
            if (Input.GetKey(KeyCode.W) && Mathf.Abs(rb.velocity.y) < 0.01f)
            {
                rb.AddForce(Vector2.up * ziplamaGucu, ForceMode2D.Impulse);
            }
        }
    }

    public void YourDead()
    {
        pManager.olum();
    }


}

  
