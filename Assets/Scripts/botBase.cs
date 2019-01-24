using System.Collections.Generic;
using MT.Economy.TradingSystem;

namespace MT
{
    namespace BotSystem
    {
        namespace Bases
        {

            public interface botBase
            {

                void die();
                botType type { get; set; }
                MT.Economy.TradingSystem.inventory inventory { get; set; }
                transportType transportType { get; set; }
                MT.BotSystem.BotPathManager pathManager { get; set; }
            }

            public enum botType
            {
                Citizen, Trader, Thieve
            }
        }
    }
}