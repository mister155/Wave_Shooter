using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool : MonoBehaviour {

    public GameObject Prefab;

    public GameObject GetObject()
    {
        if (_FreeObjects.Any())
        {
            var obj = _FreeObjects.Last();
            _FreeObjects.Remove(obj);
            obj.SetActive(true);
            return obj;
        }
        else
        {
            return Instantiate(Prefab);
        }
    }

    public void ReleaseObject(GameObject obj)
    {
        _FreeObjects.Add(obj);
        obj.SetActive(false);
    }

    private readonly List<GameObject> _FreeObjects = new List<GameObject>();

}
