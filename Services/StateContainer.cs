using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ThirdCoastSoftware.Shared;
using ThirdCoastSoftware.Shared.Components;

namespace ThirdCoastSoftware.Services
{
	public class StateContainer
	{
		private NavigationManager _navManager;
		private IJSRuntime _jsRuntime;
		internal IEnumerable<DropdownComponent> Dropdowns;

		public StateContainer(NavigationManager navManager, IJSRuntime jsRuntime)
		{
			_navManager = navManager;
			_jsRuntime = jsRuntime;
			Dropdowns = new List<DropdownComponent>();
		}


		internal void Navigate(string page) => _navManager.NavigateTo(page);

		internal async void ScrollTo(string element) => await _jsRuntime.InvokeVoidAsync("scrollTo", element);
		
		internal void CloseDropdowns(DropdownComponent? elm = null)
		{
			var dropdowns = Dropdowns.ToList();

			foreach (var dropdown in dropdowns.Where(d => d != elm))
				dropdown.Close();
		}
	}
}
