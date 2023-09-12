namespace BlackJack.Model
{
    public struct Card
    {
        public string Suit { get; set; }
        public int Value { get; set; }

        // Card value as face if beyond 10
        public override string ToString()
        {
            string faceValue;
            switch (Value)
            {
                case 11:
                    faceValue = "Jack";
                    break;
                case 12:
                    faceValue = "King";
                    break;
                case 13:
                    faceValue = "Queen";
                    break;
                case 14:
                    faceValue = "Ace";
                    break;
                default:
                    faceValue = Value.ToString(); 
                    break;
            }
            return $"{faceValue} of {Suit}";
        }
    }
}