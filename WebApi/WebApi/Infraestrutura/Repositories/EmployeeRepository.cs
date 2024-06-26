﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Domain.DTOs;
using WebApi.Domain.Model.EmployeeAggregate;

namespace WebApi.Infraestrutura.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context;

        // Ajuste o construtor para aceitar DbContextOptions<ConnectionContext>
        public EmployeeRepository(DbContextOptions<ConnectionContext> options)
        {
            _context = new ConnectionContext(options);
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<EmployeeDTO> Get(int pageNumber, int pageQuantity)
        {
            return _context.Employees
                .OrderBy(e => e.name) // Substitua "Id" pelo nome da propriedade que você deseja ordenar
                .Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(b =>
                    new EmployeeDTO()
                    {
                        Id = b.id,
                        NameEmployee = b.name,
                        Photo = b.photo
                    }).ToList();
        }

        public Employee? Get(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}
