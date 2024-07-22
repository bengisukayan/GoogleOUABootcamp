using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject objectPrefab;
    public int poolSize = 10;
    private List<GameObject> poolObjects;

    void Awake()
    {
        poolObjects = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            poolObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        foreach (GameObject obj in poolObjects)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        // E�er t�m objeler kullan�l�yorsa ve havuz doluysa, yeni bir obje olu�turmak i�in:
        GameObject newObj = Instantiate(objectPrefab);
        newObj.SetActive(false);
        poolObjects.Add(newObj);
        return newObj;
    }
}
