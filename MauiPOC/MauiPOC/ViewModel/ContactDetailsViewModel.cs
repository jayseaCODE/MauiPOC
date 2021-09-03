using Microsoft.Maui.Essentials;

namespace MauiPOC.ViewModel
{
	class ContactDetailsViewModel : BaseViewModel
	{
		public ContactDetailsViewModel(Contact contact)
		{
			Contact = contact;
		}

		public Contact Contact { get; }
	}
}
