using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFromParent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (transform.childCount >0)
        {
            var t = transform.GetChild(0);
            t.SetParent (null);

            t.SetAsLastSibling();
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
