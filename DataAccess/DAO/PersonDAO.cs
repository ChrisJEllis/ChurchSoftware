using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DataAccess.DAO
{
    public class PersonDAO
    {
        ChurchEntities ctx = new ChurchEntities();

        public List<PersonAddress> GetPeopleWithAddresses()
        {
            ChurchEntities ctx = new ChurchEntities();

            
            List<PersonAddress> people = (from p in ctx.people
                                         .Include(x=>x.address)
                                         .Include(y=>y.address.city)
                                         .Include(z=>z.address.city.state)
                                          select new PersonAddress() { 
                                            PersonId = p.PersonId,
                                            First_Name = p.First_Name,
                                            Middle_Initial = p.Middle_Initial,
                                            Last_Name = p.Last_Name,
                                            Gender = p.Gender,
                                            AddressId = p.AddressId,
                                            Holy_Ghost = p.Holy_Ghost,
                                            Baptized = p.Baptized,
                                            ChurchMember = p.ChurchMember,
                                            MaritalStatusId = p.MaritalStatusId,
                                            LastModified = p.LastModified,
                                            LastModifiedBy = p.LastModifiedBy,
                                            CreatedDate = p.CreatedDate,
                                            CreatedBy = p.CreatedBy,
                                            AddressLine1 = p.address.AddressLine1,
                                            AddressLine2 = p.address.AddressLine2,
                                            City = p.address.city.CityName,
                                            State = p.address.city.state.StateName,
                                            Zip = string.Concat(p.address.Zip5,(p.address.Zip4 ?? ""))
                                          }).ToList();
            return people;
            
        }

        public List<PersonDTO> GetPeople() {
            ChurchEntities ctx = new ChurchEntities();
            List<PersonDTO> people = (from p in ctx.people
                                         select new PersonDTO(){
                                            PersonId = p.PersonId,
                                            First_Name = p.First_Name,
                                            Middle_Initial = p.Middle_Initial,
                                            Last_Name = p.Last_Name,
                                            Gender = p.Gender,
                                            ChurchMember = p.ChurchMember,
                                            Baptized = p.Baptized,
                                            MaritalStatusId = p.MaritalStatusId,
                                            LastModified = p.LastModified,
                                            LastModifiedBy = p.LastModifiedBy,
                                            CreatedDate = p.CreatedDate,
                                            CreatedBy = p.CreatedBy,

                                            FullName = String.Concat(p.First_Name," ",p.Last_Name)
                                         }).ToList();
            return people;
        }

        public int AddPerson(string firstName, string middleInitial, string lastName, string gender, bool isMember,
                DateTime? holyGhost, DateTime? baptised, int? currentDiscipleMakerPersonId)
        {
            person per = ctx.people.Create();
            per.First_Name = firstName;
            per.Middle_Initial = middleInitial;
            per.Last_Name = lastName;
            per.Holy_Ghost = holyGhost;
            per.Baptized = baptised;
            per.ChurchMember = (sbyte)(isMember == true ? 1 : 0);
            per.LastModifiedBy = 1;
            per.CreatedBy = 1;
            ctx.people.Add(per);
            ctx.SaveChanges();
            
            return per.PersonId;
        }

        public bool DeletePerson(int personId) {
            
            
            person per = ctx.people.Find(personId);
            ctx.people.Remove(per);
            ctx.SaveChanges();
            return true;
        }
    }
}
