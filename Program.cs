using System.Diagnostics;

namespace Creational_Factory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* CREATIONAL
			 * MANAGE THE BUILDING OF OBJECT BEHIND THE SCENE, ONLY ONE OBJECT
			 Create object without exposing the creation logic to the client and refer to newly created object using a common interface.
			- encapulating object creation
			- central point of control and configuration
			- open - closed principle
			- testing and mocking of client code
			I can use the same factory object, with inside its buildin logics, to create N object across the program.
			 */
			MarketingAbstract sendingMethod = MarketingFactory.Create(MarketingMethod.Mailup);
			sendingMethod.SendEmail("a@a.it");
			sendingMethod.SendSms(1234);
			Console.WriteLine(sendingMethod.ToString());
			sendingMethod = MarketingFactory.Create(MarketingMethod.Sendingblue);
			sendingMethod.SendEmail("a@a.it");
			sendingMethod.SendSms(1234);
			Console.WriteLine(sendingMethod.ToString());
			sendingMethod = MarketingFactory.Create(MarketingMethod.Smsdriver);
			sendingMethod.SendEmail("a@a.it");
			sendingMethod.SendSms(1234);
			Console.WriteLine(sendingMethod.ToString());
			sendingMethod = MarketingFactory.Create(MarketingMethod.Mailchimp);
			sendingMethod.SendEmail("a@a.it");
			sendingMethod.SendSms(1234);
			Console.WriteLine(sendingMethod.ToString());


			//m.SmtpAddress = "ciccio";
			//m.
			//MailupMarketing mm = new MailupMarketing();	
			Debug.WriteLine("");
		}
	}
}
