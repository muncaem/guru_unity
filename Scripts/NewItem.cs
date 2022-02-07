using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewItem : MonoBehaviour
{
    [SerializeField] Text pickUpText;
    bool isPickUp;
    public string itemName;
    public Text cartListUI;
    //public ItemName name;

    //public List<string> haveList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPickUp && Input.GetKeyDown(KeyCode.Q))
        {
            PickUp();
        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            isPickUp = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
            isPickUp = false;
        }
    }

    void PickUp()
    {
        cartListUI.text = itemName;
        gameObject.SetActive(false);
    }
}
