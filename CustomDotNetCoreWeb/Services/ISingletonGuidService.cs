namespace CustomDotNetCoreWeb.Services
{
	// New Service - once per application lifetime
	public interface ISingletonGuidService
	{
		string GetGuid();
	}
}
