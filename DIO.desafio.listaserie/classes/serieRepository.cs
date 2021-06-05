using System;
using System.Collections.Generic;
using DIO.desafio.listaserie.interfaces;

namespace DIO.desafio.listaserie.classes
{
    public class serieRepository : iRepository<Series>
    {
        private List<Series> SeriesList = new List<Series>();
        public void Delete(int id)
        {
             SeriesList[id].Delete();
             
        }

        public void Insert(Series entity)
        {
            SeriesList.Add(entity);
        }

        public List<Series> ListAll()
        {
            
            return SeriesList;
        }

        public int NextId()
        {
            return SeriesList.Count;
        }

        public Series returnById(int id)
        {
            return SeriesList(id);
        }

        public void Update(int id, Series entity)
        {
           SeriesList[id] = entity;
        }
    }
}