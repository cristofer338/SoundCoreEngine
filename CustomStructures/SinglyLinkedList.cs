using SoundCoreEngine.Models;
namespace SoundCoreEngine.CustomStructures;

public class SinglyLinkedList<T>
{
    private Node<T>? head;
    private Node<T>? current;
    private int count;

    public int Count => count;

    public void AddToEnd(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (head == null)
        {
            head = newNode;
            current = head;
            count++;
            return;
        }

        Node<T> currentNode = head;

        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
        }

        currentNode.Next = newNode;
        count++;
    }

    public T? PlayNext()
    {
        if (current == null)
        {
            return default;
        }

        T value = current.Value;

        current = current.Next ?? head;

        return value;
    }

    public T? AdvanceTrack(int positions)
    {
        if (current == null || count == 0)
        {
            return default;
        }

        if (positions < 0)
        {
            return default;
        }

        for (int i = 0; i < positions; i++)
        {
            current = current.Next ?? head;
        }

        return current.Value;
    }

    public void Reverse()
    {
        Node<T>? previous = null;
        Node<T>? currentNode = head;

        while (currentNode != null)
        {
            Node<T>? next = currentNode.Next;

            currentNode.Next = previous;

            previous = currentNode;
            currentNode = next;
        }

        head = previous;
        current = head;
    }

    public void InsertSorted(T value, Comparison<T> comparison)
    {
        Node<T> newNode = new Node<T>(value);

        if (head == null)
        {
            head = newNode;
            current = head;
            count++;
            return;
        }

        if (comparison(value, head.Value) <= 0)
        {
            newNode.Next = head;
            head = newNode;
            current = head;
            count++;
            return;
        }

        Node<T> currentNode = head;

        while (currentNode.Next != null &&
               comparison(value, currentNode.Next.Value) > 0)
        {
            currentNode = currentNode.Next;
        }

        newNode.Next = currentNode.Next;
        currentNode.Next = newNode;

        count++;
    }

    public void RemoveDuplicates()
    {
        Node<T>? currentNode = head;

        while (currentNode != null)
        {
            Node<T>? runner = currentNode;

            while (runner.Next != null)
            {
                if (currentNode.Value is Track currentTrack &&
                    runner.Next.Value is Track nextTrack &&
                    currentTrack.Title == nextTrack.Title &&
                    currentTrack.Artist == nextTrack.Artist &&
                    currentTrack.Bpm == nextTrack.Bpm &&
                    currentTrack.DurationSeconds == nextTrack.DurationSeconds)
                {
                    runner.Next = runner.Next.Next;
                    count--;
                }
                else
                {
                    runner = runner.Next;
                }
            }

            currentNode = currentNode.Next;
        }

        current = head;
    }
    public void Sort(Comparison<T> comparison)
    {
        if (head == null || head.Next == null)
        {
            return;
        }

        Node<T>? currentNode = head;

        while (currentNode != null)
        {
            Node<T>? nextNode = currentNode.Next;

            while (nextNode != null)
            {
                if (comparison(currentNode.Value, nextNode.Value) > 0)
                {
                    T temp = currentNode.Value;
                    currentNode.Value = nextNode.Value;
                    nextNode.Value = temp;
                }

                nextNode = nextNode.Next;
            }

            currentNode = currentNode.Next;
        }

        current = head;
    }

    public List<T> ToList()
    {
        List<T> result = new();

        Node<T>? currentNode = head;

        while (currentNode != null)
        {
            result.Add(currentNode.Value);
            currentNode = currentNode.Next;
        }

        return result;
    }
}