using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ponz se la come
public class Player_Movement : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    public float Speed;


    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        

        // Reset MoveDelta
        moveDelta = new Vector3(x,y,0);

        // Swap sprite direction, wether you are going right or left
        if (moveDelta.x < 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x > 0)
            transform.localScale = new Vector3(-1, 1, 1);

        // Make sure you can move in this direction by casting a box there first, if the box returns null we are free to move
        hit = Physics2D.BoxCast(transform.position,boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Player","Blocking"));
        if(hit.collider == null)
        {
            // Make this thing move moveDelta.Y
            transform.Translate(0,moveDelta.y * Speed * Time.deltaTime,0);
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Player", "Blocking"));
        if (hit.collider == null)
        {
            // Make this thing move moveDelta.x
            transform.Translate(moveDelta.x * Speed * Time.deltaTime, 0, 0);
        }

    }
}
