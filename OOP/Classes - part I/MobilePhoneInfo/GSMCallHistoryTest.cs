using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneInfo
{
    class GSMCallHistoryTest
    {
        public static Call CalculateMaxCall(GSM gsm)
        {
            if (gsm.CallHistory.Count == 0)
            {
                throw new Exception("There are no calls!");
            }
            Call result = null;
            int maxDuration = int.MinValue;
            foreach (Call call in gsm.CallHistory)
            {
                if (call.Duration > maxDuration)
                {
                    maxDuration = call.Duration;
                    result = call;
                }
            }
                return result;
        }

        static void Main(string[] args)
        {
            
            GSM[] phones = new GSM[2];
            phones[0] = new GSM("My model", "My manufacturer", 100.00, "me", new Battery(), new Display());
            phones[1] = new GSM("Some model", "Some manufacturer", 100.00, "Some owner",
                new Battery("Some battery model", 10, 10, BatteryType.NiCd), new Display(3, 4000000));
            GSM myGSM = phones[0];

            myGSM.AddCall(new Call(DateTime.Now, "+359895201475", 2000));
            myGSM.AddCall(new Call(new DateTime(2013, 03, 01, 22, 20, 01), "+359888101010", 150));
            myGSM.AddCall(new Call(new DateTime(2013, 03, 05, 05, 19, 30), "+359898901475", 5));

            double price = 0.37;
            double myGSMTotalPrice = myGSM.CalculatePrice(price);

            Call longestCall = CalculateMaxCall(myGSM);
            myGSM.DeleteCall(longestCall);
            double totalPrice = myGSM.CalculatePrice(price);

            List<Call> deletedCalls = myGSM.ClearHistory();

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Printing information about the GSMs");
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i].ToString());
            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Printing information about IPhone 4S");
            Console.WriteLine(GSM.PIPhone);

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Printing information about the calls");
            foreach (Call call in myGSM.CallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("The total price for myGSM is {0}. ", myGSMTotalPrice);

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("The new total price for myGSM is {0}. ", totalPrice);

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Printing the deleted calls for myGSM");
            foreach (Call call in deletedCalls)
            {
                Console.WriteLine(call.ToString());
            }
        }
    }
}
