﻿using ExeSOLID.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeSOLID.DIP.Solucao
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteServices(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if(!cliente.IsValid())
            {
                return "Dados inválidos";
            }

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
