using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory
{
	internal class MarketingFactory
	{
		public static MarketingAbstract Create(MarketingMethod method)
		{
			var builder = ConfigurationBuilder.Create();
			switch (method)
			{
				case MarketingMethod.Mailup:
					//MarketingAbstract m = new MailupMarketing(k=> { k.SmsGateway = "sms gate";
					//												k.SmtpAddress = "smt address";
					//											});
					return new MailupMarketing(builder.Configuration(k =>
												{
													k.smsGateway = "SmsMailUp";
													k.smtpAddress = "SmtpMailUp";
												})
					);
					break;
				case MarketingMethod.Sendingblue:
					return new SendingblueMarketing(builder.Configuration(k =>
					{
						k.smsGateway = "SmsSendingBlue";
						k.smtpAddress = "NOT_AVAIABLE";
					}));
					break;
				case MarketingMethod.Mailchimp:
					return new MailchimpMarketing(builder.Configuration(k =>
					{
						k.smsGateway = "NOT_AVAIABLE";
						k.smtpAddress = "SmtpMailchimp";
					}));
					break;
				case MarketingMethod.Smsdriver:
					return new SmsdriverMarketing(builder.Configuration(k =>
					{
						k.smsGateway = "Sms_SmsDriver";
						k.smtpAddress = "NOT_AVAIABLE";
					}));
					break;
				default:
					throw new Exception();
					break;
			}
		}
	}
}