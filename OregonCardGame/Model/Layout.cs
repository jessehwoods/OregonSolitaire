using System.Text;

namespace OregonCardGame.Model
{
    /// <summary>
    /// This is the "Layout" of cards being manipulated by the player. It will hold cards, have cards added to it, and return the score of the hand.
    /// </summary>
    internal class Layout
    {
        /// <summary>
        /// The <c>LayoutContents</c> property holds the cards in the Layout.
        /// </summary>
        private List<Card> LayoutContents;

        /// <summary>
        /// Used to get the number of cards currently in the layout.
        /// </summary>
        internal int LayoutCount
        {
            get { return LayoutContents.Count; }
        }

        internal Card[] LayoutCards
        {
            get { return LayoutContents.ToArray(); }
        }

        /// <summary>
        /// The <c>Score</c> property gives the score for the current contents of the Layout.
        /// </summary>
        internal int Score
        {
            get { return ScoreCalculator.CalculateScore(LayoutContents); }
        }

        internal bool Full {
            get { return LayoutContents.Count >= MaximumLayoutSize; }
        }

        /// <summary>
        /// The <c>MaximumLayoutSize</c> property limits the size of the Layout.
        /// </summary>
        internal const int MaximumLayoutSize = 5;

        /// <summary>
        /// Constructs an empty Layout object.
        /// </summary>
        internal Layout()
        {
            LayoutContents = new List<Card>();
        }

        /// <summary>
        /// Adds a card to the Layout at the specified index and overwrites the card there.
        /// </summary>
        /// <remarks>
        /// This can only be used when the index is occupied. For adding to a Layout, use the FillLayout method.
        /// </remarks>
        /// <param name="idx">
        /// The index for the card to be replaced.
        /// </param>
        /// <param name="card">
        /// The card to be added to the Layout.
        /// </param>
        /// <exception cref="IndexOutOfRangeException">
        /// Thrown if the index is outside the current Layout size.
        /// </exception>
        private void ReplaceCard(int idx, Card card)
        {
            // Check that it's in the limits of the MaximumLayoutSize
            if (idx < 0 || idx >= LayoutContents.Count)
            {
                throw new IndexOutOfRangeException("Trying to replace a card outside the allowed indexes.");
            }
            // Add the card
            LayoutContents[idx] = card;
        }

        /// <summary>
        /// For adding cards to the Layout when it is not full yet.
        /// </summary>
        /// <remarks>
        /// When you need to add a card to a full Layout, use the AddCardToIndex method.
        /// </remarks>
        /// <param name="card">
        /// The card to be added.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the Layout is full when this is called.
        /// </exception>
        private void FillLayout(Card card)
        {
            if (Full)
            {
                throw new InvalidOperationException("Cannot FillLayout when Layout is already full.");
            }
            LayoutContents.Add(card);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (Card card in LayoutContents)
            {
                sb.Append(card.ToString() + ",");
            }
            return sb.ToString().Remove(sb.Length - 1, 1);
        }

        /// <summary>
        /// Puts a card in the layout at the provided index.
        /// </summary>
        /// <param name="idx">
        /// The index for the card to be placed.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the DrawnCard is null.
        /// </exception>
        /// <exception cref="IndexOutOfRangeException">
        /// Thrown if the index is outside of the current hand size + 1 or over maximum hand size.
        /// </exception>
        internal void PlaceCard(int idx, Card card)
        {
            if (idx > LayoutCount || idx >= MaximumLayoutSize)
            {
                throw new IndexOutOfRangeException("Trying to add card to an invalid index in layout");
            }
            if (idx == LayoutCount)
            {
                FillLayout(card);
            }
            else
            {
                ReplaceCard(idx, card);
            }
        }
    }
}
