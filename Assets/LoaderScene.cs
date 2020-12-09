using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Choring;

public class LoaderScene : MonoBehaviour
{
    public void Awake() {
        Choring.Choring.Init();
    }

    void Start()
    {
        Choring.Choring.Auth.LoginGuest(this.onLoginComplete);
    }

    void onLoginComplete()
    {
        Debug.Log(Choring.Choring.Auth.user.UserId);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
