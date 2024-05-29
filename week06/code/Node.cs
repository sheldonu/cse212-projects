public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left == null)
                Left = new Node(value);
            else
                Left.Insert(value);
        } else if (value > Data) {
            // Insert to the right
            if (Right == null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if (value == Data) {
            return true;
        } else if (value < Data) {
            if (Left != null) {
                return Left.Contains(value);
            } else {
                return false;
            }
        } else {
            if (Right != null) {
                return Right.Contains(value);
            } else {
                return false;
            }
        }
    }

    public int GetHeight() {
        // If both left and right children are null, this is a leaf node, and the height is 1
        if (Left == null && Right == null) {
            return 1;
        }

        // Get the height of the left and right subtrees
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // The height of the current node is 1 plus the maximum of the heights of the left and right subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}