using Avantica.Data;
using Avantica.Models.WebApplication3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Properties = Avantica.Models.Properties;

namespace Avantica.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly AvanticaContext context;

        public PropertiesController(AvanticaContext context)
        {
            this.context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            var respuesta = await Firstprocess().ConfigureAwait(false);
            List<Properties> datos = new List<Properties>();

            foreach (var item in respuesta.properties)
            {
                string test = item.financial?.listPrice;
                string test2 = item.lease?.leaseSummary?.monthlyRent;
                double? result = (Convert.ToDouble(test2) * 12) / Convert.ToDouble(test);
                Properties tabla = new Properties
                {
                    Address = item.address?.address1,
                    Gross_Yield = result?.ToString(),
                    Year_Built = item.physical?.yearBuilt,
                    List_Price = test?.ToString(),
                    Monthly_Rent = test2 != null ? test2.ToString() : null
                };

                datos.Add(tabla);
            }

            return View(datos);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task<Application> Firstprocess()
        {
            Uri url = new Uri("https://samplerspubcontent.blob.core.windows.net/public/properties.json");

            var response = await ConsumeServiceGetAsync(url).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(response))
            {
                return JsonConvert.DeserializeObject<Application>(response);
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<string> ConsumeServiceGetAsync(Uri url)
        {
            using var httpClient = new HttpClient();

            using var response = await Policy.HandleResult<HttpResponseMessage>(message => !message.IsSuccessStatusCode)
                  .WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(2), (result, timeSpan, retryCount, context) => { })
                  .ExecuteAsync(() => httpClient.GetAsync(url));

            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(string id)
        {

            return View(await context.Properties.ToListAsync());
        }

        // GET: Properties/Create
        public async Task<IActionResult> Create(string id)
        {
            var respuesta = await Firstprocess().ConfigureAwait(false);
            List<Properties> datos = new List<Properties>();
            Properties properties = null;

            foreach (var item in respuesta.properties)
            {
                if (item.address.address1 == id)
                {
                    string test = item.financial?.listPrice;
                    string test2 = item.lease?.leaseSummary?.monthlyRent;
                    double? result = (Convert.ToDouble(test2) * 12) / Convert.ToDouble(test);
                    Properties tabla = new Properties
                    {
                        Address = item.address?.address1,
                        Gross_Yield = result?.ToString(),
                        Year_Built = item.physical?.yearBuilt,
                        List_Price = test?.ToString(),
                        Monthly_Rent = test2 != null ? test2.ToString() : null
                    };

                    properties = tabla;
                }
            }

            if (properties == null)
            {
                return NotFound();
            }

            return View(properties);
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Properties properties)
        {
            var exist = context.Properties.FirstOrDefault(x => x.Address == properties.Address);

            if (exist == null)
            {
                if (ModelState.IsValid)
                {
                    context.Add(properties);
                    await context.SaveChangesAsync();
                    return RedirectToAction(nameof(Details));
                }
            }
            return View(properties);
        }

        // GET: Properties/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = context.Properties.FirstOrDefault(x => x.Address == id);

            double? result = Convert.ToDouble(properties.Monthly_Rent) * 12 / Convert.ToDouble(properties.List_Price);

            properties.Gross_Yield = result.ToString();

            if (properties == null)
            {
                return NotFound();
            }

            return View(properties);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Properties properties)
        {
            if (id != properties.Address)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(properties);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertiesExists(properties.Address))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
            return View(properties);
        }

        private bool PropertiesExists(string id)
        {
            return context.Properties.Any(e => e.Address == id);
        }
    }
}
