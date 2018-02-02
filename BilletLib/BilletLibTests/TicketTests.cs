using System;
using System.Collections.Generic;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibTests
{
    [TestClass]
    public class TicketTests
    {
        [TestMethod]
        public void TicketBroBizzTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 2, 1), false), true);

            int result = ticket.FinalPrice;

            Assert.AreEqual(228, result);
        }

        [TestMethod]
        public void TicketTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 2, 1), false), false);

            int result = ticket.FinalPrice;

            Assert.AreEqual(240, result);
        }

        [TestMethod]

        public void TicketWeekendTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 1, 27), false), false);

            int result = ticket.FinalPrice;

            Assert.AreEqual(192, result);
        }

        [TestMethod]

        public void TicketWeekendBroBizzTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 1, 27), false), true);

            int result = ticket.FinalPrice;

            Assert.AreEqual(182, result);
        }

        [TestMethod]

        public void TicketØresundBilTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 1, 27), true), false);

            int result = ticket.FinalPrice;

            Assert.AreEqual(410, result);
        }

        [TestMethod]

        public void TicketØresundMCTest()
        {
            Ticket ticket = new Ticket(new MC("123", new DateTime(2018, 1, 27), true), false);

            int result = ticket.FinalPrice;

            Assert.AreEqual(210, result);
        }

        [TestMethod]

        public void TicketØresundBilBrobizzTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 1, 27), true), true);

            int result = ticket.FinalPrice;

            Assert.AreEqual(161, result);
        }

        [TestMethod]

        public void TicketØresundMCBrobizzTest()
        {
            Ticket ticket = new Ticket(new MC("123", new DateTime(2018, 1, 27), true), true);

            int result = ticket.FinalPrice;

            Assert.AreEqual(73, result);
        }

        [TestMethod]

        public void KundeTotalPrisTest()
        {
            List<Ticket> ticketList = new List<Ticket>();
            ticketList.Add(new Ticket(new MC("123", new DateTime(2018, 1, 27), true), true));
            ticketList.Add(new Ticket(new Bil("123", new DateTime(2018, 1, 27), true), true));
            ticketList.Add(new Ticket(new Bil("123", new DateTime(2018, 1, 27), false), true));

            Kunde kunde = new Kunde(ticketList);

            int result = kunde.SumOfTrips();

            Assert.AreEqual(416,result);
        }
    }
}
