namespace Demo
{
    public interface IQueryService
    {
        #region IQueryService method signatures

        public Task<People[]> GetPeopleAsync();
        public Task<People> GetPeopleByIdAsync(int id);
        #endregion
    }
}
