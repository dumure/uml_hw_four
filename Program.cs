using uml_hw_four;

ClientUsersDatabase client1 = new ClientUsersDatabase(new UsersDatabase());
ClientUsersDatabase client2 = new ClientUsersDatabase(new MsSqlDatabaseAdapter(new MsSqlDatabase()));
ClientUsersDatabase client3 = new ClientUsersDatabase(new MySqlDatabaseAdapter(new MySqlDatabase()));
ClientUsersDatabase client4 = new ClientUsersDatabase(new PlSqlDatabaseAdapter(new PlSqlDatabase()));

User user = new User() { Login = "nagibator3000", Email = "peter.parker2014@outlook.com", Password="hard_password123", Id=33481};

client1.Create(user);
client2.Read(user.Id);
client3.Update(user);
client4.Delete(user.Id);