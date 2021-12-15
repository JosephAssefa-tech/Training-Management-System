using Entities;
using RepositoryFacade;
using ServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManager
{
    public class TrainingServiceComplete : ITrainigServiceCRUD, ITrainingService
    {
        ITrainingRepository _repository;
        public TrainingServiceComplete(ITrainingRepository repository)
        {
            _repository = repository;

        }
        public bool Delete(TrainingEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TrainingEntity> GetAllTraining()
        {
            throw new NotImplementedException();
        }

        public List<TrainingEntity> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public TrainingEntity GetByID(int trainingID)
        {
            return this._repository.GetByID(trainingID);

            
         
            
        }

        public string Save(TrainingEntity entity)
        {
            throw new NotImplementedException();
        }

        public string Update(TrainingEntity entity)
        {
            throw new NotImplementedException();
        }


    }
}
