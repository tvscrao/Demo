using Demo;
public class TestData
{
    #region Test data for GetPeople
    public static async Task<People[]> GetPeople()
    {
        People[] peopleList = new People[]
        {
             new People() { Name="name1", Height = 150 },
             new People() { Name="name2", Height = 160 },
             new People() { Name="name2", Height = 170 },
        };
        return peopleList;
    }
    #endregion

    #region Test data for GetPeopleById 
    public static async Task<People> GetPeopleById(int id)
    {
        return new People()
        {
            Name = "name1", Height = 150
        };
    }
    #endregion
}