using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using System.Runtime.Caching;

namespace judgewaddell.org.ApiControllers
{
	[Route("api/news")] 
	public class NewsController : ApiController 
	{

		// GET api/<controller>
		public async Task<HttpResponseMessage> Get()
		{
			var _cache = MemoryCache.Default;

			var cachedNews = _cache.Get("news");
			if (cachedNews != null) 
			{ 
				var cacheResponse = Request.CreateResponse();
				cacheResponse.Content = new StringContent(cachedNews as string, Encoding.UTF8, "application/json");
				return cacheResponse;
			}

			HttpClient client = new HttpClient();
			var clientResponse = await client.GetAsync("https://judgewaddell.apispark.net:443/v1/news/?$sort=Date+DESC");

			var response = Request.CreateResponse();
			var json = await clientResponse.Content.ReadAsStringAsync();
			response.Content = new StringContent(json, Encoding.UTF8, "application/json");

			_cache.Add("news", json, DateTimeOffset.UtcNow.AddHours(1));

			return  response;
		}

	}
}