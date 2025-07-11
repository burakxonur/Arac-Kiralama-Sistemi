﻿using CareBook.Application.İnterfaces;
using CareBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Persistence.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CarBookContext _context;
        public Repository(CarBookContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByFılterAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetByIDAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatedAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
