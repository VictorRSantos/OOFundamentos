using System.Collections.Generic;
using System.Linq;
using Balta.NotificationContext;
using Balta.SharedContext;
using SubscriotionContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Namw { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem assinatura ativa"));
                return;
            }
            else
            {
                Subscriptions.Add(subscription);
            }
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);



    }
}