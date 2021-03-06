﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using System.Runtime.Caching;
using System.Web.Hosting;
using System.IO;

namespace judgewaddell.org.ApiControllers
{
	[Route("api/award")] 
	public class AwardController : ApiController 
	{

		// GET api/<controller>
		public async Task<HttpResponseMessage> Get()
		{
			var _cache = MemoryCache.Default;

			var scholars = _cache.Get("scholars");
			if (scholars != null)
			{
				var cacheResponse = Request.CreateResponse();
				cacheResponse.Content = new StringContent(scholars as string, Encoding.UTF8, "application/json");
				return cacheResponse;
			}

			var json = File.ReadAllText(HostingEnvironment.MapPath("~/content/scholar.json"));

			var response = Request.CreateResponse();
			response.Content = new StringContent(json, Encoding.UTF8, "application/json");

			_cache.Add("scholars", json, DateTimeOffset.UtcNow.AddHours(1));

			return  response;
		}

	}
}