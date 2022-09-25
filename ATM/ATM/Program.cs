public class cardHolder 
{
    string cardnum;
    int pin;
    string firstname;
    string lastname;
    double balance;

    public cardHolder(string cardnum, int pin, string firstname, string lastname, double balance)
    {
        this.cardnum = cardnum;
        this.pin = pin;
        this.firstname = firstname;
        this.lastname = lastname;
        this.balance = balance;
    }

    public string getNum()
    { return cardnum; } 
    
    public int getPin()
    { return pin; }
    
    public string getFirstName()
    { return firstname; }
    
    public string getLastName()
    { return lastname; }
    
    public double getBalance()
    { return balance; }

    public void setNum(string newCardNum) 
    { cardnum = newCardNum; }

    public void setPin(int newPin)
    { pin = newPin; }

    public void setFirstName(string newFirstName)
    { firstname = newFirstName; }

    public void setLastName(string newLastName)
    { lastname = newLastName; }

    public void setBalance(double newBalance) 
    { balance = newBalance; }

    public static void Main(string[] args)
    { 
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw ");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much amount would you like to deposit? ");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you! Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much amount would you like to deposit? ");
            double withdrawal = double.Parse(Console.ReadLine());
            //check if user has enough money
            if (currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient Balance :(");
            }
            else 
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You are good to go! Thank you");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1234567890123456", 1234, "Jay", "Ahir", 100666646464650));
        cardHolders.Add(new cardHolder("1234567890123456", 1234, "Jay", "Ahir", 100666646464650));
        cardHolders.Add(new cardHolder("1234567890123454", 0421, "aadi", "nair", 100050));
        cardHolders.Add(new cardHolder("1234567890123455", 3490, "jaja", "aada", 155446650));
        cardHolders.Add(new cardHolder("1234567890123452", 1111, "Hh", "jay", 1649696450));

        // Prompt user  
        Console.WriteLine("Welcome to Simple ATM");
        Console.WriteLine("Please Enter your Debit Card: ");
        string debitCardNum = "";
        cardHolder currentuser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                // Check against our db
                currentuser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
            }
            catch (Exception)
            { 
                throw;
            }
        }

    }
}