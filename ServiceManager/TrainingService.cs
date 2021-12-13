using Entities;
using RepositoryFacade;
using ServiceFacade;
using System;
using System.Collections.Generic;

namespace ServiceManager
{
    public class TrainingService : ITrainigServiceCRUD
    {
        ITrainingRepository _repository;
        public TrainingService(ITrainingRepository repository)
        {
            _repository = repository;
        }

        public bool  Delete(TrainingEntity entity)
        {
   
            if(entity.Id!=0)

            {
                bool result = _repository.Delete(entity);

                return result;
            }
            else
            {
                return false;
            }
    
        }

        public List<TrainingEntity> GetAllTraining()
        {
            List<TrainingEntity> entites = this._repository.GetAllTraining();
            return entites;
            
        }
        public string Validate(TrainingEntity entity)
        {

            if (entity.Name == string.Empty)
            {
                return "Name can't be empty";

            }
            else if (entity.StartDate > entity.EndDate)
            {
                return "The start date can't be greater than the end date";
            }
            else
            {
                return string.Empty;
            }
        }
        public string Save(TrainingEntity entity)
        {
            try
            {
                string message = Validate(entity);

                if (message != string.Empty)
                {
                    return message;

                }
          
                else
                {
                    bool result = this._repository.Save(entity);
                    if (result == true)
                    {
                        return "Saved Sucessfully";
                    }
                    else
                    {
                        return "Unkonw error is occured";
                    }


                }

            }
            catch(Exception )
            {
                throw;
            }

        }

        public string Update(TrainingEntity entity)
        {
            try
            {
                string message = Validate(entity);

                if (message != string.Empty)
                {
                    return message;

                }

                else
                {
                    bool result = this._repository.Update(entity);
                    if (result == true)
                    {
                        return "Updated Sucessfully";
                    }
                    else
                    {
                        return "Unkonw error is occured";
                    }


                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
