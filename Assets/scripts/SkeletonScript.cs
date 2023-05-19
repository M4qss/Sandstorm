using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonScript : MonoBehaviour
{
    public Transform player;
    public float range;
    private Rigidbody2D rb;
    private Vector2 movement;
    public int speed = 5;
    public int Health;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();


    }
    void Update()
    {
        //Уничтожение скелета
        if (Health == 0)
        {
            PlayerStats.Score += 100;
            Destroy(gameObject);
        }
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;
        if(player.position.x - transform.position.x < 0)
        {
            Vector3 theScale = transform.localScale;
            theScale.x = -1;
            transform.localScale = theScale;
        }
        else
        {
            Vector3 theScale = transform.localScale;
            theScale.x = 1;
            transform.localScale = theScale;
        }
        
    }
    private void FixedUpdate()
    {
        MoveChar(movement);
    }
    private void MoveChar(Vector2 direction)
    {
        Vector2 mob = new Vector2(transform.position.x, transform.position.y);
        Vector2 play = new Vector2(player.position.x, player.position.y);
        if (Vector2.Distance(mob, play) < range)
        {
            rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Health -= 1;
        }
    }
}
