using PagesWpf.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesWpf.GlobalVariables
{
    public static class Vars
    {
        public static ObservableCollection<AllMaterials> Materials { get; set; } =
            new ObservableCollection<AllMaterials>
            {
                new AllMaterials { Id = 1, Name = "Офисная бумага", Price = 200 },
                new AllMaterials { Id = 2, Name = "Глянцевая бумага", Price = 350 },
                new AllMaterials { Id = 3, Name = "Картон", Price = 150 },
                new AllMaterials { Id = 4, Name = "Крафт бумага", Price = 180 }
            };
    }
}
