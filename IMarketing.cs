using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory
{
	internal interface IMarketing
	{
		//string GatewayNumber { get; set; }
		//string SmtpAddress { get; set; }

		bool SendEmail(string emailAddress);
		bool SendSms(int telephoneNumber);
		//void Config(Action<IMarketing> options);
	}
}
