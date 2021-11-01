using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplayControlPlayer : ItemDisplayControl
{

    Dictionary<string, int> itemsDictPlayer = new Dictionary<string, int>();
    GameObject gameManager;
    Items itemsRef;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        itemsRef = gameManager.GetComponent<Items>();
        itemsDictPlayer = itemsRef.PlayerItemsDict;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayItem(itemString, itemImage, itemsDictPlayer);
    }
}
