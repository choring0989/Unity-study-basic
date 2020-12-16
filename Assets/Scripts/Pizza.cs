using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("피자 냠냠");
        if (this.transform.childCount > 0)
        {
            Destroy(this.transform.GetChild(this.transform.childCount-1).gameObject);
        }
    }
}
