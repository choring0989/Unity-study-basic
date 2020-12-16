using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Choring;

public class LoaderScene : MonoBehaviour
{
    public NoticePopup noticePopup;
    
    public void Awake() {
        Choring.Choring.Init();
    }

    void Start()
    {
        Choring.Choring.Auth.LoginGuest(this.OnLoginComplete);
    }

    void OnLoginComplete()
    {
        Debug.Log(Choring.Choring.Auth.user.UserId);
        noticePopup.ShowPopup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
