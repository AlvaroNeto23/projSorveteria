﻿using Sorveteria.Dominio;
using Sorveteria.Dominio.Contrato;
using System.Collections.Generic;

namespace Sorveteria.Aplicacao
{
    public class UsuarioAplicacao
    {
        private readonly IRepositorio<Usuario> repositorio;

        public UsuarioAplicacao(IRepositorio<Usuario> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Usuario usuario)
        {
            repositorio.Salvar(usuario);
        }

        public void Excluir(Usuario usuario)
        {
            repositorio.Excluir(usuario);
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Usuario ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
