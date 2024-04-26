using AirTekSpeedyAir.Helper;
using AirTekSpeedyAir.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AirTekSpeedyAir.Models
{
    public class OrderRepo : List<IOrder>
    {
        public void LoadJson()
        {
            this.Clear();
            this.AddRange(OrderJsonReader.LoadOrdersFromJsonString(OrderJsonReader.ReadJsonFile("coding-assigment-orders.json")));
        }

        public string LoadOrdersSchedules()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= this.Count; i++)
            {
                stringBuilder.AppendLine(this[i - 1].ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
