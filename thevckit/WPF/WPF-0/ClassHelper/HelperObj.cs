using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WPF_0.ClassHelper
{
    public static class HelperObj
    {
        public static string GenericPassword( )
        {
            int _num_letters = 8;
            int _num_words = 1;

            char [] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdifghijklmnopqrstuvwxyz123456789".ToCharArray();

            Random random = new Random();
            string word = "";
            for (int i = 0; i < _num_words; i++)
            {
                for (int j = 0; j < _num_letters; j++)
                {
                    int letter_num = random.Next( 0, letters.Length );

                    word += letters [letter_num];
                }
            }
            return word;
        }

        public async static void SendEmail( string FirstName, string LastName, string Username, string Email )
        {
            MailAddress from = new MailAddress( "thevckit@mail.ru", "IT Business Software Projects." );
            MailAddress to = new MailAddress( Email );
            MailMessage message = new MailMessage( from, to );
            message.Subject = "You have been granted access by the System Administrator.";
            message.Body = $"<h2>Hi {FirstName} {LastName}!</h2> " +
                $"<h3>Use the following data to log in. Your Username:</h3> <h2> {Username} </h2> <h3>and your password: </h3> <h2> {GenericPassword()} </h2>";
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient( "smtp.mail.ru", 587 );
            client.Credentials = new NetworkCredential( "thevckit@mail.ru", "@.localhost" );
            client.EnableSsl = true;
            await client.SendMailAsync( message );
        }

        public static bool CheckEmail( string email )
        {
            Regex emailRegex = new Regex( @"\w{2,10}@\w{2,10}.\w{2,10}" );
            Match emailMatch = emailRegex.Match( email );
            if (emailMatch.Value == "")
                return false;
            else
                return true;
        }

        public static bool CheckPassword( string password )
        {
            bool isdigit = false;
            bool isupper = false;
            bool islower = false;
            bool spec = false;

            foreach (var item in password)
            {
                if (char.IsDigit( item ))
                {
                    isdigit = true;
                    break;
                }
            }

            foreach (var item in password)
            {
                if (char.IsUpper( item ))
                {
                    isupper = true;
                    break;
                }
            }

            foreach (var item in password)
            {
                if (char.IsLower( item ))
                {
                    islower = true;
                    break;
                }
            }

            foreach (var item in password)
            {
                if(item == '!' || item == '@' || item == '#' || item == '%' || item == '^' || item == '&')
                {
                    spec = true;
                    break;
                }
            }

            if (8 <= password.Length || !islower || !isupper || !isdigit || !spec)
                return false;
            else
                return true;
        }
    }
}
