using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory
{
	internal abstract class MarketingAbstract
	{
		protected string SmsGateway;
		protected string SmtpAddress;

		protected MarketingAbstract(Configuration config)
		{
			this.SmsGateway = config.SmsGateway;
			this.SmtpAddress = config.SmtpAddress;
		}

		public string ToString(string childClass)
		{
			return $"Configuration SMSGateway: {SmsGateway} - SMTPAddress: {SmtpAddress} - SendingClass: {childClass} \n\r";
		}

		internal abstract bool SendEmail(string emailAddress);
		internal abstract bool SendSms(int telephoneNumber);
	}
}
