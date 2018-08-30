using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Domain.Entities
{
    public class DefineEventEntity:EventEntity
    {
        public DateTimeOffset Date { get; set; }
    }
}
