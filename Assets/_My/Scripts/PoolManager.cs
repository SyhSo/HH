using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager instance;

    [SerializeField]
    private GameObject[] prefaps;
    private int poolSize = 1;
    private List<GameObject>[] objPools;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        InitObjPool();
    }

    private void InitObjPool()
    {
        objPools = new List<GameObject>[prefaps.Length];

        for(int i = 0; i < prefaps.Length; i++)
        {
            objPools[i] = new List<GameObject>();

            for(int j = 0; j < poolSize; j++)
            {
                GameObject obj = Instantiate(prefaps[i]);
                obj.SetActive(false);
                objPools[i].Add(obj);   
            }
        }
    }

    public GameObject ActivateObj(int index)
    {
        GameObject obj = null;

        for(int i = 0; i < objPools[index].Count; i++)
        {
            if (!objPools[index][i].activeInHierarchy)
            {
                obj = objPools[index][i];
                obj.SetActive(true);
                return obj;
            }
        }

        obj = Instantiate(prefaps[index]);
        objPools[index].Add(obj);
        obj.SetActive(true);

        return obj;
    }
}
