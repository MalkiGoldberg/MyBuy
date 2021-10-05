using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static class BranchConverts
    {
        public static DTO.BranchDTO GetBranchDTOFromDAL(DAL.Branch branch)
        {
            DTO.BranchDTO branchDTO = new DTO.BranchDTO();
            branchDTO.address = branch.address;
            branchDTO.branchId = branch.brachId;
            branchDTO.branchName = branch.branchName;
            branchDTO.city = branch.city;
            branchDTO.idManager = branch.idManager;
            branchDTO.phone = branch.phone;
            branchDTO.idChainStore = branch.idChainStore;
            branchDTO.Categories = branch.CategoryInBranches.Select(c => c.idCategory).ToList();
            return branchDTO;
        }
        public static List<DTO.BranchDTO> GetBranchesDTOFromDAL(List<DAL.Branch> branches)
        {
            List<DTO.BranchDTO> branchDTOs = new List<DTO.BranchDTO>();
            foreach (var item in branches)
            {
                branchDTOs.Add(GetBranchDTOFromDAL(item));
            }
            return branchDTOs;
        }


        public static DAL.Branch GetBranchDALFromDTO(DTO.BranchDTO branchDTO)
        {
            DAL.Branch branch = new DAL.Branch();
            branch.address = branchDTO.address;
            branch.brachId = branchDTO.branchId;
            branch.branchName = branchDTO.branchName;
            branch.city = branchDTO.city;
            branch.phone = branchDTO.phone;
            branch.idManager = branchDTO.idManager;
            branch.userName = branchDTO.userName;
            branch.password = branchDTO.password;
            branch.idChainStore = branchDTO.idChainStore;
            //branch.CategoryInBranches = branchDTO.Categories.Select(c => new DAL.CategoryInBranch { idCategory = 1 }).ToList();
            return branch;
        }
    }
}