using System.Diagnostics;

namespace UML
{
    internal class Ticket
    {
        int rootNumber;
        int price;
        DateTime dataStart;
        DateTime dataEnd;
        int place;
        bool isValid;

        public void NewTicket(DateTime dataStart, DateTime dataEnd, int price, int place, bool isValid)
        {
            rootNumber++;
            this.dataStart = dataStart;
            this.dataEnd = dataEnd;
            this.price = price;
            this.place = place;
            this.isValid = true;
        }
    }
}
