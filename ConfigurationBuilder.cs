using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory
{
	internal class ConfigurationBuilder
	{
		public string smsGateway { get; set; }
		public string smtpAddress { get; set; }

		private ConfigurationBuilder() { }

		public static ConfigurationBuilder Create() => new ConfigurationBuilder();

		//public ConfigurationBuilder WithSmsGateway(string _smsGateway)
		//{
		//	smsGateway = _smsGateway;
		//	return this;
		//}
		//public ConfigurationBuilder WithSmtpAddress(string _smtpAddress)
		//{
		//	smtpAddress = _smtpAddress;
		//	return this;
		//}

		public   Configuration Configuration(Action<ConfigurationBuilder> options)
		{
			options(this);
			//_accessories.Add(accessory.Build());
			return this.Build();
		}

		public Configuration Build()
		{
			return new Configuration
			{
				SmtpAddress = smtpAddress,
				SmsGateway = smsGateway
			};
		}

	}
}
