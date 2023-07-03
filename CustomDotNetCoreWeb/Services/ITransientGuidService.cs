namespace CustomDotNetCoreWeb.Services
{
	// New Service - every time requested
	public interface ITransientGuidService
	{
		string GetGuid();
	}
}
