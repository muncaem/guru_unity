using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class PlayerMove : MonoBehaviour
{
    float moveX; 
    float moveY;
    Rigidbody2D rb;
  
    [SerializeField] [Range(1f, 30f)] float moveSpeed = 30f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    

    transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "FieldItem")
    //    {
    //        print("Ãæµ¹!!");

    //        FieldItems fieldItems = collision.gameObject.GetComponent<FieldItems>();
    //        //pickUpText.gameObject.SetActive(true);
    //        //isPickUp = true;

    //        if (Inventory.instance.AddItem(fieldItems.GetItem()))
    //            fieldItems.DestroyItem();
    //    }
    //}

}