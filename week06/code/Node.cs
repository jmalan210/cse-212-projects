public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
       if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (Data == value)
            return true;

        if (value < Data)
        {
            if (Left is not null && Left.Contains(value))
                return true;
            else
                return false;
        }

        else if (value > Data)
        {
            if (Right is not null && Right.Contains(value))
                return true;
            else 
                return false;
        }

        else
            return false;
    }

    public int GetHeight()
    {
        int leftHeight;
        int rightHeight;
        if (Left is null)
        {
            leftHeight = 0;
        }
        else
        {
             leftHeight = Left.GetHeight();
        }

        if (Right is null)
        {
            rightHeight = 0;
        }
        else
        {
             rightHeight = Right.GetHeight();
        }
        var tallest = Math.Max(leftHeight, rightHeight);
        return tallest + 1;
    }
}