using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model.Model
{
    
    public class MStreamName
    {
        public int StreamId { get; set; }
        public string StreamName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Byte? IsDeleted { get; set; }
    }

    public class MBankBranch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string IFSC { get; set; }
        public string MICR_CODE { get; set; }
        public string SWIFT_CODE { get; set; }
        public Byte? IsActive { get; set; }
        public int? BankId { get; set; }
        public string AddressId { get; set; }
    }
    public class MCast
    {
        public int CasteId { get; set; }
        public string CastnName { get; set; }
        public string CastNameAlias { get; set; }
        public string CASTE_NAME_IN_LOCAL_LANGUAGE { get; set; }
        public string MainCastGroup { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? JURISDICTION_ID { get; set; }
        public int? CategoryId { get; set; }
        public Byte? IsNonCreamyLayer { get; set; }
    }
    
}
