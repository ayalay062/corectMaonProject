﻿using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class PersonDAL
    {

        newMaonContext DB = new newMaonContext();
        
        public List<Person> getAll()
        {
            return DB.People.ToList();
        }

        public bool uppdate(Person PersonDAL)
        {
            Person p = DB.People.FirstOrDefault(x => x.PersonTz == PersonDAL.PersonTz);
            if (p != null)
            {
                p.PersonName = PersonDAL.PersonName;
                p.Adress = PersonDAL.Adress;
                p.Email = PersonDAL.Email;
                p.PhoneNamber1 = PersonDAL.PhoneNamber1;
                p.PhoneNamber2 = PersonDAL.PhoneNamber2;

                try
                {
                    DB.SaveChanges();
                }
                catch
                {
                    return false;
                }


            }
            return true;

        }

        public long AddPerson(Person PersonDAL)
        {
            DB.People.Add(PersonDAL);

            try
            {
                DB.SaveChanges();
                return PersonDAL.PersonTz;
            }
            catch
            {
                return 0;
            }
        
        }

        public bool Delete(int personTz)
        {
            Person k = DB.People.FirstOrDefault(x => x.PersonTz == personTz);

            DB.People.Remove(k);
            try
            {
                DB.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}


