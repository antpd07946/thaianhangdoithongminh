using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class ThongKeDTO
    {
        private DateTime startDate;
        private DateTime endDate;

        public ThongKeDTO() { }
      
        public ThongKeDTO(

            DateTime startDate,
            DateTime endDate,
            int numberDays)
        {
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public DateTime StatartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }


}
