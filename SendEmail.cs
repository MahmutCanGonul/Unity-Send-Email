using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System;

public class SendMail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SendMailMessage();

    }

   

    public void SendMailMessage()
    {
        try
        {

            string email = "TO_EMAIL_ADDRESS";
            string subject = MyEscapeURL("SUBJECT");
            string body = MyEscapeURL("BODY_MESSAGE");
            Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);

        }
        catch(Exception ex)
        {
            Debug.Log(ex.Message);
        }
    }

    private string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }

}
