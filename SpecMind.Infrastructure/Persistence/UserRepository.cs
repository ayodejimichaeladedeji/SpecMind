namespace SpecMind.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly SqlConnection _sqlConnection;

        public UserRepository(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public async Task<bool> Add(User entity)
        {
            var statement = @"INSERT INTO [User](FirstName, LastName, EmailAddress, IsEmailVerified, HashedPassword, CreatedAt, UpdatedAt, IsDeleted, LastLogin, RefreshToken) 
                                VALUES(@FirstName, @LastName, @EmailAddress, @IsEmailVerified, @HashedPassword, @CreatedAt, @UpdatedAt, @IsDeleted, @LastLogin, @RefreshToken);";
            bool result = await _sqlConnection.ExecuteAsync(statement, entity) > 0;
            return result;
        }

        public Task<bool> DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}