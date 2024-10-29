﻿using CleanBlog.App.Applications.Services;
using CleanBlog.App.Dto_s.ContactsDescription;
using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanBlog.Persistence.Services
{
    public class ContactsDescriptionService : IContactsDescriptionService
    {

        readonly private IContactDescriptionReadRepository _contactDescriptionReadRepository;
        readonly private IContactDescriptionWriteRepository _contactDescriptionWriteRepository;

        public ContactsDescriptionService(IContactDescriptionReadRepository contactDescriptionReadRepository , IContactDescriptionWriteRepository contactDescriptionWriteRepository)
        {
            _contactDescriptionReadRepository = contactDescriptionReadRepository;   
            _contactDescriptionWriteRepository = contactDescriptionWriteRepository;
        }
        public async Task<bool> Create(CreateContactsDescriptionDto model)
        {
            await _contactDescriptionWriteRepository.AddAsync(new ContactsDescription() { Description=model.Description });
            await _contactDescriptionWriteRepository.SaveAsync();


            return true;
        }

        public async Task<bool> Delete(string id)
        {
            var contactsDescription= await _contactDescriptionReadRepository.GetByIdAsync(id);
            if (contactsDescription == null) throw new Exception("not found");

            _contactDescriptionWriteRepository.Remove(contactsDescription);
            await _contactDescriptionWriteRepository.SaveAsync();
            return true;
        }

        public async Task<List<ContactsDescription>> GetAll()
        {
            List<ContactsDescription> contactsDescriptions =  _contactDescriptionReadRepository.GetAll().ToList();
            return contactsDescriptions;
        }

        public async Task<ContactsDescription> GetById(string id)
        => await _contactDescriptionReadRepository.GetByIdAsync(id);

        public async Task<bool> Update(UpdateContactsDescriptionDto model)
        {
            _contactDescriptionWriteRepository.Update(new ContactsDescription() { Description= model.Description });


            await _contactDescriptionWriteRepository.SaveAsync();

            return true;

        }
    }
}
