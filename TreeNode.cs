using System;
using System.Collections.Generic;

namespace tree
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static Boolean isValidBST(TreeNode root){
            int min = -2147453648;
            int max = 2147453647;
            return privateIsValidBST(root, min, max);
        }

        private static Boolean privateIsValidBST(TreeNode root, int min, int max){
            if(root == null) return true;
            if(root.val <= min || root.val >= max) return false;

            return privateIsValidBST(root.left, min, root.val)
                    && privateIsValidBST(root.right, root.val, max);

        }
    }

}