using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Contracts
{
    public interface IUnityOfWork
    {
        IFilmeRepository FilmeRepository { get; }
        IClienteRepository ClienteRepository { get; }
        IIngressoRepository IngressoReposioty { get; }
    }
}
