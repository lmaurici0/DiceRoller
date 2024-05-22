using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVALIACAO.ViewModels
{
    public partial class DiceViewodel : ObservableObject
    {
        [ObservableProperty]
        private int quantidadeDeLados;
        
        [ObservableProperty]
        private int numeroSorteado;
    }
}
