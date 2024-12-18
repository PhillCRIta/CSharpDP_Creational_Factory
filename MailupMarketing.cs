using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Creational_Factory
{
	internal class MailupMarketing : MarketingAbstract
	{
		public MailupMarketing(Configuration options) : base(options) { }

		//public bool SendEmail(string emailAddress)
		//{
		//          Console.WriteLine("Send email with Mailup @ " + emailAddress);
		//	return true;
		//}

		//public bool SendSms(int telephoneNumber)
		//{
		//	Console.WriteLine("Send sms with Mailup @ number " + telephoneNumber);
		//	return true;
		//}

		public override string ToString()
		{
			return base.ToString(this.GetType().Name);
		}
		internal override bool SendEmail(string emailAddress)
		{
			Console.WriteLine("Send email with Mailup @ " + emailAddress);
			return true;
		}
		internal override bool SendSms(int telephoneNumber)
		{
			Console.WriteLine("Send sms with Mailup @ number " + telephoneNumber);
			return true;
		}
	}
}
