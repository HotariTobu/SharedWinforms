using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SharedWinforms.Extension
{
    public static class TreeNodeEX
    {
        public static TreeNode GetNodeFromPoint(this TreeView tree, int x, int y)
        {
            if (tree == null)
            {
                throw new ArgumentNullException("tree");
            }

            return GetNodeFromPoint(tree, new Point(x, y));
        }

        public static TreeNode GetNodeFromPoint(this TreeView tree, Point point)
        {
            if (tree == null)
            {
                throw new ArgumentNullException("tree");
            }

            TreeNode node = tree.GetNodeAt(point);

            if (node == null || !node.Bounds.Contains(point))
            {
                return null;
            }
            else
            {
                return node;
            }
        }

        public static TreeNode GetNodeFromPath(this TreeView tree, string path)
        {
            if (tree == null)
            {
                throw new ArgumentNullException("tree");
            }

            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            TreeNode node = null;

            foreach (string name in path.Split(new string[] { tree.PathSeparator }, StringSplitOptions.None))
            {
                try
                {
                    if (node == null)
                    {
                        node = tree.Nodes.GetNodeFromName(name).First();
                    }
                    else
                    {
                        node = node.Nodes.GetNodeFromName(name).First();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return node;
        }

        public static TreeNode GetRootNode(this TreeNode node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            TreeNode rootNode = node;

            while (rootNode.Level > 0)
            {
                rootNode = rootNode.Parent;
            }

            return rootNode;
        }

        public static TreeNode[] GetNodeFromName(this TreeNodeCollection collection, string name)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection");
            }

            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            return collection.Cast<TreeNode>().Where(x => x.Text.Equals(name)).ToArray();
        }
    }
}
