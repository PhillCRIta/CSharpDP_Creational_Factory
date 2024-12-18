using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory
{
	internal class MailchimpMarketing : MarketingAbstract
	{
		public MailchimpMarketing(Configuration options) : base(options)
		{
		}

		//public bool SendEmail(string emailAddress)
		//{

		//}

		//public bool SendSms(int telephoneNumber)
		//{

		//}
		public override string ToString()
		{
			return base.ToString(this.GetType().Name);
		}
		internal override bool SendEmail(string emailAddress)
		{
			Console.WriteLine("Send email with Mailchimp @ " + emailAddress);
			return true;
		}

		internal override bool SendSms(int telephoneNumber)
		{
			Console.WriteLine("Cannot use Mailchimp to send SMS");
			return false;
		}
	}
}
