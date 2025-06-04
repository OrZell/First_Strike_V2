using System;

namespace First_Strike_V2.Models
{
    public static class ArmyFactory
    {
        //public static Army CreateIDF()
        //{
        //    return IDF.CreateIDF();
        //}
    }

    interface ICreateStrikeOption
    {
        StrikeOptions CreateStrikeOption();
    }

    public class CreateDrone : ICreateStrikeOption
    {
        public StrikeOptions CreateStrikeOption() =>
          new Drone();
    }

    public class CreateFighterJet : ICreateStrikeOption
    {
        public StrikeOptions CreateStrikeOption() =>
          new FighterJet();
    }

    public class CreateArtillery : ICreateStrikeOption
    {
        public StrikeOptions CreateStrikeOption() =>
          new Artillery();
    }

    public class StrikeOptionsFactory 
    {
        private List<StrikeOptions> WarMachines = new List<StrikeOptions>();
        private Dictionary<string, ICreateStrikeOption> StrikeOptionCreator = new Dictionary<string, ICreateStrikeOption>();

        public StrikeOptionsFactory()
        {
            StrikeOptionCreator["Drone"] = new CreateDrone();
            StrikeOptionCreator["FighterJet"] = new CreateFighterJet();
            StrikeOptionCreator["Artillery"] = new CreateArtillery();


        }

        public StrikeOptions WarMachineDeployment(string type)
        {
            if (!StrikeOptionCreator.ContainsKey(type))
            {
                throw new ArgumentException("Invalid War Machine Type!");
            }

            StrikeOptions strikeOption = StrikeOptionCreator[type].CreateStrikeOption();
            WarMachines.Add(strikeOption);
            return strikeOption;
        }
    }
}


