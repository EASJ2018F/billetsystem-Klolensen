﻿using System;
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
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 2, 1)), true);

            int result = ticket.FinalPrice;

            Assert.AreEqual(228, result);
        }

        [TestMethod]
        public void TicketTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 2, 1)), false);

            int result = ticket.FinalPrice;

            Assert.AreEqual(240, result);
        }

        [TestMethod]

        public void TicketWeekendTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 1, 27)), false);

            int result = ticket.FinalPrice;

            Assert.AreEqual(192, result);
        }

        [TestMethod]

        public void TicketWeekendBroBizzTest()
        {
            Ticket ticket = new Ticket(new Bil("123", new DateTime(2018, 1, 27)), true);

            int result = ticket.FinalPrice;

            Assert.AreEqual(182, result);
        }
    }
}
