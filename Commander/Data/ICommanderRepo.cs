using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
   

        public interface ICommanderRepo
        {
            IEnumerable<Command> GetAllCommands();
            Command GetCommandById(int id);
            void CreateCommand(Command cmd);
            void UpdateCommand(Command cmd);
            void DeleteCommand(Command cmd);
            bool SaveChanges();
        }

}
