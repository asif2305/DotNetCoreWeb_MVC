namespace CustomDotNetCoreWeb.Services
{
	// New Service - once per request
	public interface IScopedGuidService
	{
		string GetGuid();
	}
}
