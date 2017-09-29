using System;
using System.Threading.Tasks;

namespace DemoApp.Data.Interfaces
{
	public interface IDemoAppApiServices
	{
		Task<string> PostRequest(string api, object data);

		Task<T> PostRequest<T>(string api, object data);

		Task<T> PostImageFileRequest<T>(byte[] fileBytes, string filename, string api);

		Task<T> GetRequest<T>(string api);

		Task<string> GetRequest(string api);

		Task<string> DeleteRequest(string api);
	}
}
