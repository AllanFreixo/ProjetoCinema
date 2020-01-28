using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Projeto.Service.Mapping;
using Projeto.Service.Model.Filme;
using Projeto.Data.Mapping;
using Projeto.Data.Contracts;
using Projeto.Data.Entity;

namespace Projeto.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(FilmeCadastroModel model,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                unityOfWork.FilmeRepository.Inserir(mapper.Map<Filme>(model));
                return Ok("Filme Cadastrado com Sucesso");

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpPut]
        public IActionResult Put(FilmeAlterarModel model,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                unityOfWork.FilmeRepository.Alterar(mapper.Map<Filme>(model));
                return Ok("Filme Alterado com Sucesso");

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

                unityOfWork.FilmeRepository.Excluir(Id);
                return Ok("Filme Excluido com Sucesso");

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpGet]
        [ProducesResponseType(typeof(List<FilmeConsultaModel>), 200)]
        public IActionResult PesquisarTodos(
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                return Ok(mapper.Map<List<FilmeConsultaModel>>
                    (unityOfWork.FilmeRepository.PesquisarTodos()));


            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(FilmeConsultaModel), 200)]
        public IActionResult PesquisarClienteId(int id,
            [FromServices] IMapper mapper, [FromServices] IUnityOfWork unityOfWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Ocorreram erros de Validação");
            }
            try
            {

                return Ok(mapper.Map<FilmeConsultaModel>
                    (unityOfWork.FilmeRepository.PesquisarId(id)));


            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

    }
}