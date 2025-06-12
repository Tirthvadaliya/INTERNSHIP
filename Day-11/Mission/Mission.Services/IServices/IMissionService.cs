using Mission.Entities.Models;

namespace Mission.Services.IServices
{
    public interface IMissionService
    {
        Task<List<MissionRequestViewModel>> GetAllMissionAsync();
        Task<MissionRequestViewModel?> GetMissionById(int id);
        Task<bool> AddMission(MissionRequestViewModel model);

        //delete
        //Task<bool> DeleteMission(int id);
        Task<bool> DeleteMission(int id);

        // update mission by id
        Task<bool> UpdateMission(int id, MissionRequestViewModel model);
        //Task<bool> UpdateMission(MissionRequestViewModel model);

        // update mission
        //Task<bool> UpdateMission(MissionRequestViewModel model);

        Task<List<MissionDetailResponseModel>> GetClientSideMissionList();
    }
}
