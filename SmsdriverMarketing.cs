using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory
{
	internal class SmsdriverMarketing : MarketingAbstract
	{
		public SmsdriverMarketing(Configuration options) : base(options)
		{
		}

		//public bool SendEmail(string emailAddress)
		//{
		//	Console.WriteLine("Cannot send email with Smsdriver");
		//	return false;
		//}

		//public bool SendSms(int telephoneNumber)
		//{
		//	Console.WriteLine("Send sms with Smsdriver @ " + telephoneNumber);
		//	return true;
		//}
		public override string ToString()
		{
			return base.ToString(this.GetType().Name);
		}
		internal override bool SendEmail(string emailAddress)
		{
			Console.WriteLine("Cannot send email with Smsdriver");
			return false;
		}

		internal override bool SendSms(int telephoneNumber)
		{
			Console.WriteLine("Send sms with Smsdriver @ " + telephoneNumber);
			return true;
		}
	}
}
