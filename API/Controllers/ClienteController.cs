using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapper;
using API.Dtos;
using Domain.Interfaces;
using Domain.Entities;
using API.Helpers;
using API.Services;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers;
[ApiVersion("1.0")]
[ApiVersion("1.1")]
public class ClienteController : BaseApiController
{
    private readonly IUnitOfWork unitofwork;
    private readonly IMapper mapper;
    private readonly IUserService _Userservice;

    public ClienteController(IUnitOfWork unitofwork, IMapper mapper, IUserService Userservice)
    {
        this.unitofwork = unitofwork;
        this.mapper = mapper;
        this._Userservice = Userservice;
    }

    //Inicio de los controladores v1.0
    [HttpGet]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<ClienteDto>>> Get()
    {
        var entidad = await unitofwork.Clientes.GetAllAsync();
        return mapper.Map<List<ClienteDto>>(entidad);
    }
    [HttpGet("{id}")]
    [Authorize]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ClienteDto>> Get(int id)
    {
        var entidad = await unitofwork.Clientes.GetByIdAsync(id);
        if (entidad == null)
        {
            return NotFound();
        }
        return this.mapper.Map<ClienteDto>(entidad);
    }
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<ClienteDto>> Put(int id, [FromBody] ClienteDto entidadDto)
    {
        if (entidadDto == null)
        {
            return NotFound();
        }
        var entidad = this.mapper.Map<Cliente>(entidadDto);
        unitofwork.Clientes.Update(entidad);
        await unitofwork.SaveAsync();
        return entidadDto;
    }
    [HttpDelete("{id}")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var entidad = await unitofwork.Clientes.GetByIdAsync(id);
        if (entidad == null)
        {
            return NotFound();
        }
        unitofwork.Clientes.Remove(entidad);
        await unitofwork.SaveAsync();
        return NoContent();
    }

    //metodos version 1.1
    
    [HttpGet("pagination")]
    [Authorize(Roles = "Administrador")]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<ClienteDto>>> GetPagination([FromQuery] Params pagparams)
    {
        var entidad = await unitofwork.Clientes.GetAllAsync(pagparams.PageIndex, pagparams.PageSize, pagparams.Search);
        var listEntidad = mapper.Map<List<ClienteDto>>(entidad.registros);
        return new Pager<ClienteDto>(listEntidad, entidad.totalRegistros, pagparams.PageIndex, pagparams.PageSize, pagparams.Search);
    }
}
