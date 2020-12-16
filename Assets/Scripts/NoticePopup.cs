using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoticePopup : MonoBehaviour
{
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void ShowPopup()
    {
        this.gameObject.SetActive(true);
        txt.text = "안녕하세요 " + Choring.Choring.Auth.user.UserId + "님," +
            "\n카메라에 마커를 비춰주세요." +
            "\n\n오브젝트를 터치하면 상호작용을 할 수 있어요.";
    }

    public void ClosePopup()
    {
        this.gameObject.SetActive(false);
    }
}
