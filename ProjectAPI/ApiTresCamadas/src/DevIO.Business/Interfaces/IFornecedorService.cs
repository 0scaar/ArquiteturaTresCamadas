﻿using System;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
	public interface IFornecedorService
	{
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);
    }
}

