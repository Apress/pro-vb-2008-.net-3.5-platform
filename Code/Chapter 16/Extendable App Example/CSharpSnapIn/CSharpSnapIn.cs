using System;
using CommonSnappableTypes;
using System.Windows.Forms;

namespace CSharpSnapIn
{
	[CompanyInfo(Name = "Intertech Training", 
        Url = "www.intertechtraining.com")]
	public class CSharpSnapInModule : IAppFunctionality 
	{
		void IAppFunctionality.DoIt()
		{
			MessageBox.Show("You have just used the C# snap in!");
		}
	}
}
