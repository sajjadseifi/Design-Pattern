namespace Design_Pattern.Adapter.Bank
{
    public class BankDetails
    {
        private string bankName;
        private string accHolderName;
        private long accNumber;
        public string getBankName() => bankName;
        public void setBankName(string bankName) => this.bankName = bankName;
        public string getAccHolderName() => accHolderName;
        public void setAccHolderName(string accHolderName) => this.accHolderName = accHolderName;
        public long getAccNumber() => accNumber;
        public void setAccNumber(long accNumber) => this.accNumber = accNumber;
    }
}