using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK
{
    class Program
    {
        static void Main(string[] args)
        {
            dslk ds = new dslk();
            ds.pHead = new Node(); // khởi tạo trước khi sử dụng
            ds.pHead.Key = 1;
            ds.pHead.Next = new Node();// khởi tạo trước khi sử dụng
            ds.pHead.Next.Key = 2;
            Node p = new Node(); // khởi tạo trước khi sử dụng
            p = ds.pHead;
            do
            {
                Console.WriteLine("{0}", p.Key);
                p = p.Next;
            } while (p != null);
            Console.ReadKey();
        }
    }
}
