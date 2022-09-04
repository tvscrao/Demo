namespace Demo
{
    public interface IQueryBase
    {
        #region IQueryBase method signatures

        public Task<People[]> GetPeople();

        public Task<People> GetPeopleById(int id);

        #endregion
    }
}