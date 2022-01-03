# Unity-Send-Email
Unity Send Email to Another Address



💣CODE:
                 
                 
                 
                  public void SendMailMessage()
                {
                  try
                   {

                     string email = "TO_ADDRESS"; //TO_ADDRESS
                     string subject = MyEscapeURL("SUBJECT");
                      string body = MyEscapeURL("BODY_MESSAGE");
                       Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);    // OPEN YOUR LOCAL EMAIL URL SO THAT REALLY SECURE

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
         
         
         
OUTPUT:


![mailImage](https://user-images.githubusercontent.com/75094927/147932109-5b2274d3-144e-481a-a328-c84166179e14.png)





☑️NOTE YOU CAN ADD RATE FUNCTION FOR USER RATING YOUR APP ON GOOGLE PLAY:


                   Application.OpenURL ("market://details?id=" + Application.productName);






