using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SearchTrees
{
    public class NodeBST
    {
        public int _key;
        public NodeBST _left, _right;

        public NodeBST(int key)
        {
            _key = key;
            _left = _right = null;
        }
    }



    public class BinarySearchTree
    {
        public NodeBST _root;
        public int _sumOfLeaves;


        public BinarySearchTree()
        {
            _root = null;
        }

        public BinarySearchTree(int keyValue)
        {
            _root = new NodeBST(keyValue);
        }

        public void Insert(int keyValue)
        {
            _root = InsertNode(keyValue, _root);
        }

        private NodeBST InsertNode(int keyValue, NodeBST node)
        {
            // If the tree is empty, return a new node for root.
            if (node == null)
            {
                node = new NodeBST(keyValue);
                return node;
            }

            if (keyValue < node._key){
                node._left = InsertNode(keyValue, node._left);
            }
            else {
                node._right = InsertNode(keyValue, node._right);
            }
            return node;
        }


        public int SumLeftLeaves()
        {
            _sumOfLeaves = 0;
            CheckAndSumEachLeftLeaf(_root);
            return _sumOfLeaves;
        }

        private void CheckAndSumEachLeftLeaf(NodeBST node)
        {
            if (node == null){
                _sumOfLeaves += 0;
                return;
            }

            if (node._left != null)
            { 
                if (node._left._left == null && node._left._right == null){
                    _sumOfLeaves += node._left._key;
                }
                else {
                    CheckAndSumEachLeftLeaf(node._left);
                }
            }
            
            if (node._right != null) 
            {
                if (node._right._left != null || node._right._right != null){
                    CheckAndSumEachLeftLeaf(node._right);
                }
            }
        }


        public int SumRightLeaves()
        {
            _sumOfLeaves = 0;
            CheckAndSumEachRightLeaf(_root);
            return _sumOfLeaves;
        }

        private void CheckAndSumEachRightLeaf(NodeBST node)
        {
            if (node == null)
            {
                _sumOfLeaves += 0;
                return;
            }

            if (node._left != null)
            {
                if (node._left._left != null || node._left._right != null){
                    CheckAndSumEachRightLeaf(node._left);
                }
            }

            if (node._right != null)
            {
                if (node._right._left == null && node._right._right == null){
                    _sumOfLeaves += node._right._key;
                }
                else {
                    CheckAndSumEachRightLeaf(node._right);
                }
            }
        }
    }
}
