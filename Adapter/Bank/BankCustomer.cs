namespace Design_Pattern.Adapter.Bank
{
    public class BankCustomer : BankDetails, ICreditCard
    {
        public void generateBankDetails()
        {
            setAccHolderName("CodeGate");
            setAccNumber(1234567);
            setBankName("CG ");
        }

        public string getCreditCard()
        {
            long accno = getAccNumber();
            string accholdername = getAccHolderName();
            string bname = getBankName();
            return ("The Account number " + accno + " of " + accholdername + " in " + bname + "bank is valid and authenticated for issuing the credit card. ");
        }
    }
}