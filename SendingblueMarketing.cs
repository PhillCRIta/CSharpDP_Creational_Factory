using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory
{
	internal class SendingblueMarketing : MarketingAbstract
	{
		public SendingblueMarketing(Configuration options) : base(options)
		{
		}

		//public bool SendEmail(string emailAddress)
		//{
		//	Console.WriteLine("Cannot use Sendingblue to send email");
		//	return false;
		//}

		//public bool SendSms(int telephoneNumber)
		//{
		//	Console.WriteLine("Send email with Sendingblue @ " + telephoneNumber);
		//	return true;
		//}
		public override string ToString()
		{
			return base.ToString(this.GetType().Name);
		}
		internal override bool SendEmail(string emailAddress)
		{
			Console.WriteLine("Cannot use Sendingblue to send email");
			return false;
		}

		internal override bool SendSms(int telephoneNumber)
		{
			Console.WriteLine("Send email with Sendingblue @ " + telephoneNumber);
			return true;
		}
	}
}
