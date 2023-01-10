using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_cards : MonoBehaviour
{
    public GameObject cardPrefab;

    void InstantiateCard()
    {
        GameObject newCard = Instantiate(cardPrefab, transform, worldPositionStays: false);
        newCard.transform.SetAsLastSibling();  
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount < 3)
        {
            InstantiateCard();
        }
    }
}
