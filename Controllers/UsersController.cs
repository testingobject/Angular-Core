using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Angular_Core.Services.Repository;
using Angular_Core.Services.IRepository;

namespace Angular_Core.Data.Models.Controllers
{
    [Route("api/user")]
    public class UsersController : Controller
    {
        private IUserService _userService;

        public UsersController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet("list")]
        public IEnumerable<User> Getuser()
        {
            return _userService.GetAll();
        }

    }
}