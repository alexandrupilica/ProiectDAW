﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectDAW.Entities;
using ProiectDAW.Enums;
using ProiectDAW.IServices;

namespace ProiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _service;
        public AlbumController(IAlbumService service)
        {
            this._service = service;
        }

        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            var response = _service.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult Get(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPost("update")]
        [Authorize]
        public IActionResult Update(Album album)
        {
            if (!UserIsInRole(UserTypeEnum.Admin))
                return Unauthorized("You are not in role to permit this action");

            _service.Update(album);
            return Ok();
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult Create(Album album)
        {
            if (!UserIsInRole(UserTypeEnum.Admin))
                return Unauthorized("You are not in role to permit this action");

            _service.Insert(album);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            if (!UserIsInRole(UserTypeEnum.Admin))
                return Unauthorized("You are not in role to permit this action");

            _service.Delete(id);
            return Ok();
        }

        private bool UserIsInRole(params UserTypeEnum[] roles)
        {
            var user = GetUserFromContext();
            return roles.Select(x => x.ToString()).Contains(user.Type);
        }

        private User GetUserFromContext() =>
            (User)HttpContext.Items["User"];
    }
}
