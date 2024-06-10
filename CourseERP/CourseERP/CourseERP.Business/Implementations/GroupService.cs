using CourseERP.Business.Interfaces;
using CourseERP.Core.Models;
using GroupERPDATABASE.DAL;

namespace CourseERP.Business.Implementations;

public class GroupService : IGroupService
{
    public void Create(Group group)
    {
        CourseERPDATABASE.Groups.Add(group);
    }

    public Group Get(int id)
    {
        Group wantedGroup = CourseERPDATABASE.Groups.Find(x => x.Id == id);

        if (wantedGroup is null)
            throw new NullReferenceException("Group not found!");

        return wantedGroup;
    }

    public List<Group> GetAll()
    {
        return CourseERPDATABASE.Groups;
    }

    public void Remove(int id)
    {
        Group wantedGroup = CourseERPDATABASE.Groups.Find(x => x.Id == id);

        if (wantedGroup is null)
            throw new NullReferenceException("Group not found!");

        CourseERPDATABASE.Groups.Remove(wantedGroup);
    }

}
