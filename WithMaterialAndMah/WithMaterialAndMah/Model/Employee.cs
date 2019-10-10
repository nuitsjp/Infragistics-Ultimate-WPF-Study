using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithMaterialAndMah.Model
{
    /// <summary>
    /// A class which represents the Employee table.
    /// </summary>
    [Table("Employee", Schema = "HumanResources")]
    public partial class Employee
    {

        [Key]
        public virtual int BusinessEntityID { get; set; }

        public virtual string NationalIDNumber { get; set; }

        public virtual string LoginID { get; set; }

        public virtual string JobTitle { get; set; }

        public virtual DateTime BirthDate { get; set; }

        public virtual string MaritalStatus { get; set; }

        public virtual string Gender { get; set; }

        public virtual DateTime HireDate { get; set; }

        public virtual bool SalariedFlag { get; set; }

        public virtual short VacationHours { get; set; }

        public virtual short SickLeaveHours { get; set; }

        public virtual bool CurrentFlag { get; set; }

        public virtual Guid rowguid { get; set; }

        public virtual DateTime ModifiedDate { get; set; }


    }
}
