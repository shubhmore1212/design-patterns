namespace Basics.Principles.Encapsulation
{
    public class BadBankAccount
    {
        public decimal Balance;
        //due to public field it can be changed in any class
        //suppose we donot have to set Balance to negative
        //then we have to mention explicitly that in every service
    }
}
