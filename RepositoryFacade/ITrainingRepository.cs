using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFacade
{
    public interface ITrainingRepository
    {
        bool Save(TrainingEntity entity);
        bool Update(TrainingEntity entity);
        bool Delete(TrainingEntity entity);
        List<TrainingEntity> GetAllTraining();

        TrainingEntity GetByID(int trainingID);

        List<TrainingEntity> GetByDateRange(DateTime startDate, DateTime endDate);

    }
}
