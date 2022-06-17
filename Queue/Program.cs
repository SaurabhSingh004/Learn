namespace QueueDemo
{
    class Queue{
        static int poi=90;
        int []queue;
        int front,rear,max;
        public Queue(int size)
        {
            queue=new int[size];
            rear=-1;
            front=0;
            max = size;
        }

        public void Push(int num)
        {
            if (rear == max-1)
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            
            queue[++rear] = num;
            
        }
        public void pop()
        {
            if(front==rear+1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            front++;
        }

        public void print()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + queue[i]);
                }
            }
        }

        static void Main()
        {
            Queue Q = new Queue(10);

            Console.WriteLine(poi);
            Q.Push(10);
            Q.Push(20);
            Q.Push(30);
            Q.Push(40);
            Q.Push(50);

            Console.WriteLine("Items are : ");
            Q.print();
            
            Q.pop();
            Q.pop();
            Q.Push(66);
            Q.Push(60);
            

            Console.WriteLine("Items are : ");
            Q.print();
        }

    }
}