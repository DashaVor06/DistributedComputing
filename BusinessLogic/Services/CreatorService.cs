using System.Collections.Generic;
using AutoMapper;
using BusinessLogic.DTO.Request;
using BusinessLogic.DTO.Response;
using DataAccess.Models;
using DataAccess.Repositories;

namespace BusinessLogic.Servicies
{
    public class CreatorService : IBaseService<CreatorRequestTo, CreatorResponseTo>
    {
        private IRepository<Creator> _repository;
        private IMapper _mapper;

        public CreatorService(IRepository<Creator> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<CreatorResponseTo> GetAll()
        {
            return _mapper.Map<List<CreatorResponseTo>>(_repository.GetAll());
        }
        public CreatorResponseTo? GetById(int id)
        {
            if (_repository.Exists(id))
            {
                return _mapper.Map<CreatorResponseTo>(_repository.GetById(id));
            }
            return null;
        }
        public CreatorResponseTo Create(CreatorRequestTo entity)
        { 
            Creator creator = _mapper.Map<Creator>(entity);
            creator.Id = _repository.GetLastId() + 1;
            _repository.Create(creator);
            return _mapper.Map<CreatorResponseTo>(creator);
        }
        public CreatorResponseTo? Update(CreatorRequestTo entity)
        {
            if (_repository.Exists(_mapper.Map<Creator>(entity).Id)){
                _repository.Update(_mapper.Map<Creator>(entity));
                return _mapper.Map<CreatorResponseTo>(entity);
            }
            return null;
        }
        public bool DeleteById(int id)
        {
            if (_repository.Exists(id))
            {
                _repository.Delete(id);
                return true;
            }
            return false;
        }
    }
}
