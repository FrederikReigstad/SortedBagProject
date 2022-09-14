using SortedBagProject.Implementation;
using SortedBagProject.Interfaces;

namespace XUnitTestProject
{
    public class SortedBagTest
    {
        [Fact]
        public void CreateSortedBag()
        {
            // Arrange   
            ISortedBag bag;

            // Act
            bag = new SortedBag();

            // Assert
            Assert.NotNull(bag);
            Assert.True(bag is SortedBag);
            Assert.Equal(0, bag.Count);
            Assert.True(bag.IsEmpty);
        }

        [Fact]
        public void AddNumberToSortedBag()
        {
            // Arrange
            ISortedBag bag = new SortedBag();

            // Act
            bag.Add(1);

            // Assert
            Assert.Equal(1, bag.Count);
            Assert.False(bag.IsEmpty);
            Assert.Contains(1, bag.Items);
        }

        [Fact]
        public void AddSameNumberTwice()
        {
            //Arrange
            ISortedBag bag = new SortedBag();
            bag.Add(2);
            bag.Add(1);

            // Act
            bag.Add(1);

            // Assert
            Assert.Equal(3, bag.Count);
            Assert.Equal(1, bag.Peek());
        }

        [Fact]
        public void ClearExpectEmptySortedBag()
        {
            // Arrange
            ISortedBag bag = new SortedBag();
            bag.Add(3);
            bag.Add(2);
            bag.Add(1);

            // Act
            bag.Clear();

            // Assert
            Assert.Equal(0, bag.Count);
            Assert.True(bag.IsEmpty);
        }

        [Fact]
        public void FetchFromNonemptySortedBag()
        {
            // Arrange
            ISortedBag bag = new SortedBag();
            bag.Add(3);
            bag.Add(2);

            // Act
            int result = bag.Fetch();

            // Assert
            Assert.Equal(2, result);
            Assert.Equal(1, bag.Count);
            Assert.Equal(3, bag.Peek());
        }

        [Fact]
        public void FetchFromEmptySortedBagExpectInvalidOperationException()
        {
            // Arrange
            ISortedBag bag = new SortedBag();

            // Act
            Action ac = (() => bag.Fetch());

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(ac);
            Assert.Equal("SortedBag is empty", ex.Message);
        }

        [Fact]
        public void PeekFromNonemptySortedBag()
        {
            // Arrange
            ISortedBag bag = new SortedBag();
            bag.Add(3);
            bag.Add(2);

            // Act
            int result = bag.Peek();

            // Assert
            Assert.Equal(2, result);
            Assert.Equal(2, bag.Count);
        }

        [Fact]
        public void PeekFromEmptySortedBagExpectInvalidOperationException()
        {
            // Arrange
            ISortedBag bag = new SortedBag();

            // Act
            Action ac = (() => bag.Peek());

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(ac);
            Assert.Equal("SortedBag is empty", ex.Message);
        }

    }
}