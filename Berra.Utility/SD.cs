﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berra.Utility
{
    public static class SD //Status Detail
    {
        public const string ManagerRole = "Manager";
        public const string AdminRole = "Admin";
        public const string FrontDeskRole = "Front";
        public const string CustomerRole = "Customer"; //Accessed only if the user doesn't specify a role upon creation of the program.

        public const string StatusPending = "Pending_Payment";
        public const string StatusSubmitted = "Submitted_PaymentApproved";
        public const string StatusRejected = "Rejected_Payment";
        public const string StatusInProcess = "Being Prepared";
        public const string StatusReady = "Ready for Pickup";
        public const string StatusCompleted = "Completed";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";
        public const string SessionCart = "SessionCart";
    }
}
