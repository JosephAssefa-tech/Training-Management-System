using Entities;
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
            throw new NotImplementedException();
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
