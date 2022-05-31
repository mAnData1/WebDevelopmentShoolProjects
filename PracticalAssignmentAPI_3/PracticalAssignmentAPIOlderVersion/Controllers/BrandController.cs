using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticalAssignmentAPIOlderVersion.Business.Models.Brand;
using PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignmentAPIOlderVersion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : BaseController<IBrandService,Brand,BrandResponseModel,BrandRequestModel>
    {
        public BrandController(IBrandService brandService)
            :base(brandService)
        {
                
        }
    }
}
