using DataAcessLogic;
using DataModels.Models;
using Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryManager
{
    public class TrainingRepository : ITrainingRepository
    {
        TrainingIMSContext context = new TrainingIMSContext();

        public bool Delete(TrainingEntity entity)
        {
            try
            {
                TableTraining table = entity.MapToTable<TableTraining>();
          

                context.TableTrainings.Remove(table);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TrainingEntity> GetAllTraining()
        {
            List<TableTraining> tables = context.TableTrainings.Include(x=>x.TrainingType).ToList();
            List<TrainingEntity> entites = new List<TrainingEntity>();

            foreach(var table in tables)
            {
                TrainingEntity entity = new TrainingEntity(table);
          


                entites.Add(entity);

            }
            return entites;
    
        }

        public List<TrainingEntity> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            List<TableTraining> tables = context.TableTrainings.Where(x => x.StartDate >= startDate && x.EndDate <= endDate).ToList();
            List<TrainingEntity> entites = new List<TrainingEntity>();
            foreach(var table in tables)
            {
                TrainingEntity entity = new TrainingEntity(table);
                entites.Add(entity);
            }
            return entites;
        }

        public TrainingEntity GetByID(int trainingID)
        {
            TableTraining table = context.TableTrainings.Where(x => x.Id == trainingID).FirstOrDefault();

            return new TrainingEntity(table);
        }

        public bool Save(TrainingEntity entity)
        {
            try
            {
                TableTraining table = entity.MapToTable<TableTraining>();
                // table.TrainingType = entity.TrainingType.MapToTable();

                context.TableTrainings.Add(table);
                context.SaveChanges();
                return true;

            }
         catch(Exception)
            {
                throw;
            }



        }

        public bool Update(TrainingEntity entity)
        {
            try
            {
                TableTraining old = context.TableTrainings.Find(entity.Id);


                old.Id = entity.Id;
                old.Name = entity.Name;
                old.StartDate = entity.StartDate;
                old.EndDate = entity.EndDate;
                old.Fund = entity.Fund;
                old.TrainingTypeId = entity.TrainingType.Id;
                old.VerificationCode = entity.VerificationCode;
                old.Status = entity.Status;
                old.TargetAudience = entity.TargetAudience;

                context.Entry(old).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
