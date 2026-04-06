namespace DataAccessLayer.Login
{
    public class Login
    {
        private readonly DbHelper _db;
        public Login(DbHelper db)
        {
            _db = db;
        }
        public bool FindByEmail()
        {
            var query = "select * from Logindtls";
            return _db.ExecuteQuery(query);
        }
    }
}
