using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticalAssignmentAPIOlderVersion.Business.Models.Car;
using PracticalAssignmentAPIOlderVersion.Business.Services;
using PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using PracticalAssignmentAPIOlderVersion.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignmentAPIOlderVersion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : BaseController<ICarService, Car, CarResponseModel, CarRequestModel>
    {
        public CarsController(ICarService carService)
            :base(carService)
        {

        }
       
    }
}
