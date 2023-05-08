using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class playerManager : MonoBehaviour
{
    public GameObject[] basketPrefabs;
    public Transform spawnPoint;
    public BasketManager basketManager;

    void Start()
    {
        int selectedBasket = basketManager.selectedBasket;
        GameObject prefab = basketPrefabs[selectedBasket];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity) as GameObject;
        Debug.Log("Selected basket: " + selectedBasket);
    }





}
