using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            //return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;

    public List<Item> items = new List<Item>();

    //void Start()
    //{
    //    slotCnt = 10;
    //}

    public bool AddItem(Item _item)
    {
        if (items.Count < 10)
        {
            items.Add(_item);
            if (onChangeItem != null)
                onChangeItem.Invoke();
            return true;
        }
        return false;
    }


    //void Update()
    //{
    //    if (isPickUp && Input.GetKeyDown(KeyCode.Space))
    //        PickUP();
    //}


    

    //private void OnTriggerExit2D(Collider2D col)
    //{
    //    if (col.gameObject.tag.Equals("Player"))
    //    {
    //        pickUpText.gameObject.SetActive(false);
    //        isPickUp = flase;
    //    }
    //}

    //void PickUP()
    //{
    //    Destroy(gameObject);
    //}
}
