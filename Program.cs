using System;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(1);
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(7);
            TreeNode node2 = new TreeNode(6, node3, node4);
            TreeNode tree = new TreeNode(5, node1, node2);

            Console.WriteLine(TreeNode.isValidBST(tree));
        }
    }
}
