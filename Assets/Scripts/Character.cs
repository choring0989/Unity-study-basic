using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        Debug.Log("눌렸어요!!");
        ani.Play("run");
    }
}
