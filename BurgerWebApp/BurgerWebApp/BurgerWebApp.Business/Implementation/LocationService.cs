﻿using BurgerWebApp.Business.Abstraction;
using BurgerWebApp.Business.Mappers;
using BurgerWebApp.DataAccess.Abstraction;
using BurgerWebApp.DomainModels;
using BurgerWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerWebApp.Business.Implementation
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> _locationRepository;
        public LocationService(IRepository<Location> locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public void Add(LocationViewModel viewModel)
        {
            Location location = new Location(_locationRepository.RandomId(),viewModel.Name, viewModel.Address,viewModel.OpensAt, viewModel.ClosesAt);
            _locationRepository.Add(location);
        }

        public void Delete(int? id)
        {
            _locationRepository.Delete(_locationRepository.GetEntity(id));
        }

        public List<LocationViewModel> GetAll()
        {
            return _locationRepository.GetAll().Select(location => location.ToViewModel()).ToList();
        }

        public LocationViewModel GetLocation(int? id)
        {
          return _locationRepository.GetEntity(id).ToViewModel();
        }

        public void Update(LocationViewModel viewModel)
        {
            Location location = new Location(viewModel.Id,viewModel.Name,viewModel.Address,viewModel.OpensAt,viewModel.ClosesAt);
            _locationRepository.Update(location);
        }

        public bool ValidateInputs(LocationViewModel viewModel)
        {
            if (string.IsNullOrEmpty(viewModel.Name) || string.IsNullOrEmpty(viewModel.Address))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
