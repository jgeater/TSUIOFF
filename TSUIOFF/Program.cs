using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSUIOFF
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Type tsProgress = Type.GetTypeFromProgID("Microsoft.SMS.TSProgressUI");
                dynamic comObject = Activator.CreateInstance(tsProgress);

                comObject.CloseProgressDialog();

                if (System.Runtime.InteropServices.Marshal.IsComObject(comObject) == true)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(comObject);
            }
            catch
            {
                Console.WriteLine("Task sequence environment not found!");
            }
        }
    }
}
