using ChainOfRes.ConvalidError;

namespace ChainOfRes
{
    internal class Program
    {
        //richiedi nome utente
        //richiedi password
        //check della password
        //stampa eventuali errori di convalida
        static void Main(string[] args)
        {
            User user = new User();
            var LenghtCheck = new MinLenghtCheck();
            var MissingNum = new MissingNumCheck();                           
            var MissingCapital = new MissingCapitalCheck();
            var MissinSChar = new SpecialCharCheck();
            user.SetSuccesor(LenghtCheck)
                .SetSuccesor(MissingNum)
                .SetSuccesor(MissingCapital)
                .SetSuccesor(MissinSChar);
            user.InitializeUser();  
            user.InitializePassword();
            
            

            
        }
    }
}
