using System;
namespace Classes_struct_and_namespaces
{
    public class Method_Overload
    {
        public int Result { get; set; }

        public void Add(int x,int y , out int R)
        {
            R = x + y;
        }
        public void Add(int x,int y, int z, out int R)
        {
            R = x + y + z;
        }
        public void Add(int w ,int x,int y,int z, out int R)
        {
            R = x + y + z + w;
        }
        
    }
}
