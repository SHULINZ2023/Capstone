
 
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Text.Encodings.Web;
using System;
using Data;
using Models;
using myDotNetMVCApp.Models;
using Utilities;



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
                 businessProfile = _DbContext.BusinessProfiles.FirstOrDefault() ?? throw new DataNotFoundException("BusinessProfile Not found"),
                 sections = _DbContext.Sections.Where(e=>e.Status=="approved").ToList() ?? throw new DataNotFoundException("Sections Not found"),
                 Galleries= _DbContext.Galleries.Where(e=>e.Status=="approved").ToList() ?? throw new DataNotFoundException("Galleries not found"),
                 
            };
            var section_offeredService = indexViewModel.sections.Find(e=>e.Section_type=="OfferedServices"); 
            _logger.LogInformation(section_offeredService.Section_desc);

            return indexViewModel;
        }
      
       

      
    
    }
}
