class CreditLimitCalculator
{
    static void Main(string[] args)
    {
        // declaring variables for input
        int accountNumber;
        int initialBalance;
        int charges;
        int credits;
        int creditLimit;

        // declaring variable for new balance 
        int newBalance;

        // declaring variable to break loop
        int terminateLoop = 0;

        do
        {
            if (terminateLoop == 0)
            {
                // input account number
                Console.Write("Enter Account Number:  ");
                accountNumber = Convert.ToInt32(Console.ReadLine());
            }

            else
            {
                // input account number
                Console.Write("\nEnter Account Number:  ");
                accountNumber = Convert.ToInt32(Console.ReadLine());
            }

            // input initial balance
            Console.Write("Enter Balance At The Beginning Of The Month:  ");
            initialBalance = Convert.ToInt32(Console.ReadLine());

            // input charges
            Console.Write("Enter Total Of All Items Charged:  ");
            charges = Convert.ToInt32(Console.ReadLine());

            // input credits
            Console.Write("Enter Total Of All The Credits:  ");
            credits = Convert.ToInt32(Console.ReadLine());

            // input credit limit
            Console.Write("Enter Credit Limit:  ");
            creditLimit = Convert.ToInt32(Console.ReadLine());

            // calculating new balance
            newBalance = initialBalance + charges - credits;

            Console.WriteLine();    // just for spacing purpose

            // displying account number
            Console.WriteLine("Account Number:  " + accountNumber);

            // displying new balance
            Console.WriteLine("New Balance:  " + newBalance);
            
            // checking if the newBalance exceeds credit limit or not
            if (newBalance > creditLimit)
            {
                Console.WriteLine("Credit Limit Exceeds");
            }

            Console.WriteLine();    // just for spacing purpose

            // do you want to continue
            Console.Write("Do You Want To Check Another Account, If Yes Than Enter 1 Or If No Than Enter 0:  ");
            terminateLoop = Convert.ToInt32(Console.ReadLine());

        } while (terminateLoop == 1);
    }
}