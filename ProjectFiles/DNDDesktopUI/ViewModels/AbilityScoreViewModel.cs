using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class AbilityScoreViewModel : Screen
    {
        //Properties 
        public String AbilityScoreName
        {
            get;
            set;
        } = "Ability Scores";

        public String AbilityScoreDescription 
        { 
            get; 
            set; 
        } = "Roll You Ability Scores";

    }
}
