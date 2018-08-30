using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain.Entities
{
   public class DailyEventEntity:EventEntity
    {
        public TimeSpan Time { get; set; }
    }
}
