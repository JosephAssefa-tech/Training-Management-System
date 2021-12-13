using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFacade
{
    public interface ITrainigServiceCRUD
    {
        string Save(TrainingEntity entity);
        string Update(TrainingEntity entity);
        bool Delete(TrainingEntity entity);
        List<TrainingEntity> GetAllTraining();

    }
}
