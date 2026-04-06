using System.Text;

namespace DataAccessLayer
{
    public class DBUpdate(DbHelper db)
    {
        private const int _DBVersion = 1;
        private readonly DbHelper _db = db;

        public bool ApplyDBUpdate(int startVersion)
        {
            var query = new StringBuilder();
            for (int i = startVersion; i <= _DBVersion; i++)
            {
                switch (i)
                {
                    case 1:
                        var query1 = "CREATE TABLE users ( user_id SERIAL PRIMARY KEY, user_name VARCHAR(100) NOT NULL UNIQUE, email VARCHAR(150) NOT NULL UNIQUE, password_hash TEXT NOT NULL, is_active BOOLEAN NOT NULL DEFAULT TRUE, created_on TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP );";
                        query.Append(query1);
                        break;
                    case 2:
                        var Query2 = "ALTER TABLE users ADD CONSTRAINT uq_users_user_name UNIQUE (user_name); ALTER TABLE users ADD CONSTRAINT uq_users_email UNIQUE (email);";
                        query.Append(Query2);
                        break;
                }

            }
            return _db.ExecuteQuery(query.ToString());

        }




    }
}
