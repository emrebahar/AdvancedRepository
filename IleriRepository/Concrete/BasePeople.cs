using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class BasePeople
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthOfDate { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        public string HouseNumber { get; set; }
        public int DistrictId { get; set; }
        public List<string> GetAddress()
        {
            List<string> AddressList = new List<string>();
            AddressList.Add(GetTitle());
            AddressList.Add(Street);
            AddressList.Add(Avenue);
            AddressList.Add(HouseNumber);
            return AddressList;

        }
        public int GetAge()
        {
            if (BirthOfDate.Month < DateTime.Now.Month)
            {
                return DateTime.Now.Year - BirthOfDate.Year;
            }
            else
            {
                return DateTime.Now.Year - BirthOfDate.Year - 1;
            }
        }
        public virtual string GetTitle()
        {
            return "Sn " + Name + " " + SurName;
        }
    }
}
