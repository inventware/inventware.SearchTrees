using SearchTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTreeTest
{
    [TestClass]
    public class BinarySearchTreeTest
    {
        [TestMethod]
        public void Insert_5_InTheRootKey()
        {
            var bst = new BinarySearchTree();
            
            bst.Insert(5);

            Assert.AreEqual(bst._root._key, 5);
        }


        [TestMethod]
        public void Insert_5_6_InTheBST()
        {
            var bst = new BinarySearchTree();

            bst.Insert(5);
            bst.Insert(6);

            Assert.AreEqual(bst._root._key, 5);
            Assert.AreEqual(bst._root._left, null);
            Assert.AreEqual(bst._root._right._key, 6);
        }


        [TestMethod]
        public void Insert_5_6_7_InTheBST()
        {
            var bst = new BinarySearchTree();

            bst.Insert(5);
            bst.Insert(6);
            bst.Insert(7);

            Assert.AreEqual(bst._root._key, 5);
            Assert.AreEqual(bst._root._left, null);
            Assert.AreEqual(bst._root._right._key, 6);
            Assert.AreEqual(bst._root._right._left, null);
            Assert.AreEqual(bst._root._right._right._key, 7);
        }


        [TestMethod]
        public void Insert_5_6_7_3_InTheBST()
        {
            var bst = new BinarySearchTree();

            bst.Insert(5);
            bst.Insert(6);
            bst.Insert(7);
            bst.Insert(3);

            Assert.AreEqual(bst._root._key, 5);
            Assert.AreEqual(bst._root._left._key, 3);
            Assert.AreEqual(bst._root._right._key, 6);
            Assert.AreEqual(bst._root._right._left, null);
            Assert.AreEqual(bst._root._right._right._key, 7);
        }

        [TestMethod]
        public void Insert_3_9_20_15_7_InTheTreeNode()
        {
            // It doesn't BST, because 9 is greater than 3 (root).
            //           3
            //         /   \
            //        9     20
            //      /  \   /  \
            //            15   7

            var bst = new BinarySearchTree(3);
            bst._root._left = new NodeBST(9);
            bst._root._right = new NodeBST(20);
            bst._root._right._left = new NodeBST(15);
            bst._root._right._right = new NodeBST(7);

            Assert.AreEqual(bst._root._key, 3);
            Assert.AreEqual(bst._root._left._key, 9);
            Assert.AreEqual(bst._root._right._key, 20);
            Assert.AreEqual(bst._root._right._left._key, 15);
            Assert.AreEqual(bst._root._right._right._key, 7);
        }


        [TestMethod]
        public void SumLeftLeavesNodesForTheKeys_3_InTheTreeNode()
        {
            var bst = new BinarySearchTree(3);

            Assert.AreEqual(bst._root._key, 3);

            int sumOfLeftLeaves = bst.SumLeftLeaves();
            Assert.AreEqual(sumOfLeftLeaves, 0);
        }


        [TestMethod]
        public void SumLeftLeavesNodesForTheKeys_3_9_20_15_7_InTheTreeNode()
        {
            // It doesn't BST, because 9 is greater than 3 (root).
            //           3
            //         /   \
            //        9     20
            //      /  \   /  \
            //            15   7

            var bst = new BinarySearchTree(3);
            bst._root._left = new NodeBST(9);
            bst._root._right = new NodeBST(20);
            bst._root._right._left = new NodeBST(15);
            bst._root._right._right = new NodeBST(7);

            Assert.AreEqual(bst._root._key, 3);
            Assert.AreEqual(bst._root._left._key, 9);
            Assert.AreEqual(bst._root._right._key, 20);
            Assert.AreEqual(bst._root._right._left._key, 15);
            Assert.AreEqual(bst._root._right._right._key, 7);

            int sumOfLeftLeaves = bst.SumLeftLeaves();
            Assert.AreEqual(sumOfLeftLeaves, 24);
        }


        [TestMethod]
        public void SumLeftLeavesNodesForTheKeys_3_9_20_6_15_7_InTheTreeNode()
        {
            // It doesn't BST, because 9 is greater than 3 (root).
            //           3
            //         /   \
            //        9     20
            //      /  \   /  \
            //     6      15    7
            //    / \    /  \  /  \
            //                 17  

            var bst = new BinarySearchTree(3);
            bst._root._left = new NodeBST(9);
            bst._root._left._left = new NodeBST(6);
            bst._root._right = new NodeBST(20);
            bst._root._right._left = new NodeBST(15);
            bst._root._right._right = new NodeBST(7);
            bst._root._right._right._left = new NodeBST(17);

            Assert.AreEqual(bst._root._key, 3);
            Assert.AreEqual(bst._root._left._key, 9);
            Assert.AreEqual(bst._root._right._key, 20);
            Assert.AreEqual(bst._root._right._left._key, 15);
            Assert.AreEqual(bst._root._right._right._key, 7);

            int sumOfLeftLeaves = bst.SumLeftLeaves();
            Assert.AreEqual(sumOfLeftLeaves, 38);
        }


        [TestMethod]
        public void SumRightLeavesNodesForTheKeys_3_9_20_15_7_InTheTreeNode()
        {
            // It doesn't BST, because 9 is greater than 3 (root).
            //           3
            //         /   \
            //        9     20
            //      /  \   /  \
            //            15   7

            var bst = new BinarySearchTree(3);
            bst._root._left = new NodeBST(9);
            bst._root._right = new NodeBST(20);
            bst._root._right._left = new NodeBST(15);
            bst._root._right._right = new NodeBST(7);

            Assert.AreEqual(bst._root._key, 3);
            Assert.AreEqual(bst._root._left._key, 9);
            Assert.AreEqual(bst._root._right._key, 20);
            Assert.AreEqual(bst._root._right._left._key, 15);
            Assert.AreEqual(bst._root._right._right._key, 7);

            int sumOfLeftLeaves = bst.SumRightLeaves();
            Assert.AreEqual(sumOfLeftLeaves, 7);
        }


        [TestMethod]
        public void SumRightLeavesNodesForTheKeys_3_9_20_15_31_7_InTheTreeNode()
        {
            // It doesn't BST, because 9 is greater than 3 (root).
            //           3
            //         /   \
            //        9     20
            //      /  \   /  \
            //            15   7
            //           /  \
            //               31

            var bst = new BinarySearchTree(3);
            bst._root._left = new NodeBST(9);
            bst._root._right = new NodeBST(20);
            bst._root._right._left = new NodeBST(15);
            bst._root._right._left._right = new NodeBST(31);
            bst._root._right._right = new NodeBST(7);

            Assert.AreEqual(bst._root._key, 3);
            Assert.AreEqual(bst._root._left._key, 9);
            Assert.AreEqual(bst._root._right._key, 20);
            Assert.AreEqual(bst._root._right._left._key, 15);
            Assert.AreEqual(bst._root._right._left._right._key, 31);
            Assert.AreEqual(bst._root._right._right._key, 7);

            int sumOfLeftLeaves = bst.SumRightLeaves();
            Assert.AreEqual(sumOfLeftLeaves, 38);
        }
    }
}
