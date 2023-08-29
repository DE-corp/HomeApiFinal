using HomeApi.Contracts.Models.Rooms;
using HomeApi.Data.Models;
using System.Threading.Tasks;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Room в базе 
    /// </summary>
    public interface IRoomRepository
    {
        Task<Room> GetRoomByName(string name);
        Task AddRoom(Room room);
        Task EditRoom(Room room, EditRoomRequest request);
    }
}