
 
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Text.Encodings.Web;
using System;
using Data;
using Models;
using myDotNetMVCApp.Models;


namespace Services
{
    public class IndexService
    {
        private  MassageDbContext _DbContext;
        private readonly ILogger<IndexService> _logger;
    
        public IndexService(MassageDbContext DbContext)
        {
            _DbContext = DbContext;
            _logger = LoggerFactory.Create(builder => builder.AddConsole())
                       .CreateLogger<IndexService>();
        }

        public IndexViewModel GetData4Index()
        {
            var indexViewModel = new IndexViewModel()
            {
                OfferedServices = _DbContext.OfferedServices.Where(e=>e.Status=="approved").ToList(),
                 PrivateChefs = _DbContext.PrivateChefs.Where(e=>e.Status=="approved").ToList(),
                 MssgTherapies= _DbContext.MassageTherapies.Where(e=>e.Status=="approved").ToList(),
                 FutureEvents = _DbContext.FutureEvents.Where(e=>e.Status=="approved").ToList(),
            };
       

            return indexViewModel;
        }
      
       

      
    
    }
}
