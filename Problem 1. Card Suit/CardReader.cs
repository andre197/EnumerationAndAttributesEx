using System;

public class CardReader : IComparable<CardReader>
{
    private CardSuit suit;

    private CardRank rank;

    public CardReader(string rank, string suit)
    {
        this.suit = (CardSuit)Enum.Parse(typeof(CardSuit), suit);
        this.rank = (CardRank)Enum.Parse(typeof(CardRank), rank);
    }

    public int CompareTo(CardReader other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        if (this.suit == other.suit)
        {
            return (int)this.rank - (int)other.rank;
        }
        return (int)this.suit - (int)other.suit;
    }

    public override string ToString()
    {
        return $"Card name: {rank} of {suit}; Card power: {(int)rank + (int)suit}";
    }
}

