using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFacade
{
    public interface ITrainingService
    {


        TrainingEntity GetByID(int trainingID);

        List<TrainingEntity> GetByDateRange(DateTime startDate, DateTime endDate);
    }
}
