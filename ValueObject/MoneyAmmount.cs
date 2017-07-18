namespace ValueObject
{
    class MoneyAmount
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public MoneyAmount(decimal amount, string currency="$")
        {
            Amount = amount;
            Currency = currency;
        }
        public MoneyAmount Scale(decimal factor) => new MoneyAmount(this.Amount * factor, this.Currency);
        public static MoneyAmount operator *(MoneyAmount money, decimal facor) => money.Scale(facor);
        public static bool operator ==(MoneyAmount a, MoneyAmount b) => object.ReferenceEquals(a, null) &&
                                                                        object.ReferenceEquals(b, null) ||
                                                                        !object.ReferenceEquals(a, null) &&
                                                                        a.Equals(b);
        public static bool operator !=(MoneyAmount a, MoneyAmount b) => !(a == b);
        public override bool Equals(object obj) => this.Equals(obj as MoneyAmount);
        private bool Equals(MoneyAmount obj) => obj != null &&
                                                obj.Amount == this.Amount &&
                                                obj.Currency == this.Currency;
        public override int GetHashCode() => this.Amount.GetHashCode() ^ this.Currency.GetHashCode();

        public override string ToString() => $"{this.Amount}{this.Currency}";
    }
}
