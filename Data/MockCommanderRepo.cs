using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public void CreateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command{ Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Water" },
        new Command{ Id=1, HowTo="Cut an egg", Line="Get Knife", Platform="Knife" },
        new Command{ Id=2, HowTo="Make an egg", Line="Get Chicken", Platform="Chicken" }
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command{ Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle" };
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }
  }
}