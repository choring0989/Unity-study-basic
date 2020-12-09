using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;

namespace Choring
{ 

public class Auth
{
    public Firebase.Auth.FirebaseAuth auth;
    public Firebase.Auth.FirebaseUser user;

    public Auth Init() {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        return this;
    }

    public void LoginGuest(System.Action onLoginComplete) {
        auth.SignInAnonymouslyAsync().ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInAnonymouslyAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInAnonymouslyAsync encountered an error: " + task.Exception);
                return;
            }

            this.user = task.Result;
            
            onLoginComplete();
        });
    }
}
}