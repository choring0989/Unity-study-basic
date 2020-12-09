using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;

namespace Choring
{

public class Choring : MonoBehaviour
{
    public static Auth Auth = new Auth();

    public void Awake()
    {
        DontDestroyOnLoad(this);
     }

    public static void Init()
    {
        //Auth = await Task.Run(() => Auth.Init());
        Auth = Auth.Init();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
}