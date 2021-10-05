using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BranchBL
    {
        public DTO.BranchDTO GetBranch(int id)
        {
            return Converts.BranchConverts.GetBranchDTOFromDAL(new DAL.BranchDAL().GetBranch(id));
        }
        public List<DTO.BranchDTO> GetBranches()
        {
            return Converts.BranchConverts.GetBranchesDTOFromDAL(new DAL.BranchDAL().GetBranches());
        }
        public DTO.BranchDTO SignUp(DTO.BranchDTO branchDTO)
        {
           DAL.Branch b= Converts.BranchConverts.GetBranchDALFromDTO(branchDTO);
           DAL.BranchDAL branchDAL = new DAL.BranchDAL();
           b=branchDAL.SignUp(b);
           return Converts.BranchConverts.GetBranchDTOFromDAL(b);
        }
        //malki
        public bool AddBranch(DTO.BranchDTO branchDTO)
        {
            DAL.Branch branch = Converts.BranchConverts.GetBranchDALFromDTO(branchDTO);
            DAL.BranchDAL branchDAL = new DAL.BranchDAL();
            return branchDAL.AddBranch(branch);
        }
        //
        public bool SignUpBranch(DTO.BranchDTO branchDTO)
        {
            DAL.Branch branch = Converts.BranchConverts.GetBranchDALFromDTO(branchDTO);
            DAL.BranchDAL branchDAL = new DAL.BranchDAL();
            return branchDAL.SignUpBranch(branch);
        }

    }
}
