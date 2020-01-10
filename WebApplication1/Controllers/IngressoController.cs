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
using Projeto.Service.Model.Ingresso;

namespace Projeto.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngressoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(IngressoCadastroModel model,
           [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                unityOfWork.IngressoReposioty.Inserir(mapper.Map<Ingresso>(model));
                return Ok("Ingresso Cadastrado com Sucesso");

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpPut]
        public IActionResult Put(IngressoEdicaoModel model,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                unityOfWork.IngressoReposioty.Alterar(mapper.Map<Ingresso>(model));
                return Ok("Ingresso Alterado com Sucesso");

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

                unityOfWork.IngressoReposioty.Excluir(Id);
                return Ok("Ingresso Excluido com Sucesso");

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpGet]
        [ProducesResponseType(typeof(List<IngressoConsultaModel>), 200)]
        public IActionResult PesquisarTodos(IngressoConsultaModel model,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                return Ok(mapper.Map<List<IngressoConsultaModel>>
                    (unityOfWork.IngressoReposioty.PesquisarTodos()));


            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<IngressoConsultaModel>), 200)]
        public IActionResult PesquisarClienteId(int id,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                return Ok(mapper.Map<List<IngressoConsultaModel>>
                    (unityOfWork.IngressoReposioty.PesquisarId(id)));


            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
    }
}