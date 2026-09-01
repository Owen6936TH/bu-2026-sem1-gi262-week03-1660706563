using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        private Item[] items = new Item[0];

        public void CollectItem(Item item)
        {
            var collectedItems = new Item[items.Length + 1];
            items.CopyTo(collectedItems, 0);
            collectedItems[items.Length] = item;
            items = collectedItems;
        }

        protected void LevelUp()
        {
        }
    }
}
