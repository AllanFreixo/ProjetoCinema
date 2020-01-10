using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Projeto.Service.Mapping;
using Projeto.Service.Model.Cliente;
using Projeto.Data.Mapping;
using Projeto.Data.Contracts;
using Projeto.Data.Entity;



namespace Projeto.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ClienteCadastroModel model,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                unityOfWork.ClienteRepository.Inserir(mapper.Map<Cliente>(model));
                return Ok("Cliente Cadastrado com Sucesso");

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpPut]
        public IActionResult Put(ClienteAlterarModel model,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                unityOfWork.ClienteRepository.Alterar(mapper.Map<Cliente>(model));
                return Ok("Cliente Alterado com Sucesso");

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                unityOfWork.ClienteRepository.Excluir(Id);
                return Ok("Cliente Excluido com Sucesso");

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ClienteConsultaModel>),200)]
        public IActionResult PesquisarTodos(ClienteConsultaModel model,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                return Ok(mapper.Map<List<ClienteConsultaModel>>
                    (unityOfWork.ClienteRepository.PesquisarTodos()));


            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<ClienteConsultaModel>), 200)]
        public IActionResult PesquisarClienteId(int id,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                return Ok(mapper.Map<List<ClienteConsultaModel>>
                    (unityOfWork.ClienteRepository.PesquisarId(id)));


            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
    }
}