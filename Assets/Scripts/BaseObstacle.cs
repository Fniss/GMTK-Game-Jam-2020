using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObstacle : MonoBehaviour
{
    public int pointsValue = 1    ;
        public bool hasDoneDamage = false;

        public GameObject onDestroy;
        public bool doesBreak=true;
    // Start is called before the first frame update
    public void DestroyNow()
    {
        Instantiate(onDestroy,transform.position, Quaternion.identity);
        if (doesBreak)
            Destroy (gameObject);
    }
}
