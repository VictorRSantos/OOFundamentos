using System;
using Balta.SharedContext;
using Balta.SubscriptionContext;

namespace SubscriotionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}